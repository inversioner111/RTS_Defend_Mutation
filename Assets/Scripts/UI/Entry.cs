using System;
using UnityEngine;
namespace RTS
{
    public class Entry
    {
        public ViewCtrl viewCtrl { get; private set; } 

        public Game game { get;private set; }
        public DataFactroy dataFactroy { get; set; } = new DataFactroy();
        public UnitsView unitsView { get; private set; }
        public ViewMgr viewMgr { get; } = new ViewMgr();

        public Entry()
        {
            viewCtrl = new ViewCtrl(viewMgr);
        }
        public void Start(Transform map)
        {
            game = new Game(dataFactroy.Factroy(), getPositions(map));
            game.Start();
            game.notify = viewCtrl;
        }

        private Vector3[] getPositions(Transform transform)
        {
            var ps = transform.Find("positions");
            var array = new Vector3[ps.childCount];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ps.Find(i.ToString()).position;
            }
            return array;
        }
    }
}