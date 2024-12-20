using System;
using UnityEngine;
namespace RTS
{
    public class UI : MonoBehaviour
    {
        public Game game { get;private set; }
        public DataFactroy dataFactroy { get; set; } = new DataFactroy();
        public GameUI gameUI { get; private set; }

        public void Start()
        {
            gameUI = new GameUI();
            game = new Game(dataFactroy.Factroy(), getPositions());
            game.notify = gameUI;
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