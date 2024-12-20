using System;
using UnityEngine;
namespace RTS
{
    public class Entry : MonoBehaviour
    {
        public Game game { get;private set; }
        public DataFactroy dataFactroy { get; set; } = new DataFactroy();
        public UnitsView unitsView { get; private set; }

        public void Start()
        {
            unitsView = new UnitsView();
            game = new Game(dataFactroy.Factroy(), getPositions());
            game.Start();
            game.notify = unitsView;
        }

        private Vector3[] getPositions()
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