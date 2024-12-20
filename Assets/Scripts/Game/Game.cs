using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RTS
{
    public class Game
    {
        public UnitRepository unitRepository { get; } = new UnitRepository();
        private UnitFactroy factroy = new UnitFactroy();

        private Payment payment;
        public Map map { get; }
        public Player player { get; } = new Player();
        public Database dataBase { get; set; }
        public INotify notify { get; set; }

        public Game(Database database, Vector3[] positions)
        {
            dataBase = database;
            payment = new Payment(database.Get("units"), player);
            this.map = new Map(positions);
        }
        public bool CreateUnit(int typeId, int posId)
        {
            if (!map.IsPosEmpty(posId))
                return false;
            if (!payment.isPayed(typeId))
                return false;
            Unit unit = factroy.NewUnit(typeId);
            unitRepository.Add(unit);
            map.Place(unit.transform,posId);
            notify?.OnCreateUnit(unit.Id, typeId, unit.transform.position);
            return true;
        }
    }
}
