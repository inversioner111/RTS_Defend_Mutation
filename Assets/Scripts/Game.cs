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
        private Map map;
        public Game(Database database, Player player, Vector3[] positions)
        {
            payment = new Payment(database, player);
            this.map = new Map(positions);
        }
        public bool CreateUnit(int typeId, int posId)
        {
            if (!payment.isPayed(typeId))
                return false;
            Unit unit = factroy.NewUnit(typeId);
            unitRepository.Add(unit);
            map.Place(unit,posId);
            return true;
        }
    }
}
