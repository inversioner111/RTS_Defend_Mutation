using System;
using UnityEngine;

namespace RTS
{
    public class Map
    {
        private Vector3[] positions;
        private bool[] values;
        public int Count => positions.Length;
        public Vector3 this[int index] => positions[index];
        public Map(Vector3[] positions)
        {
            this.positions = positions;
            values = new bool[positions.Length];
        }
        public void Place(Transform unit,int posId)
        {
            unit.position = positions[posId];
            values[posId] = true;
        }


        public bool IsPosEmpty(int posId)
        {
            return !values[posId];
        }
    }
}
