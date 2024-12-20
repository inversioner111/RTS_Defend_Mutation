using UnityEngine;

namespace RTS
{
    public class Map
    {
        private Vector3[] positions;

        public Map(Vector3[] positions)
        {
            this.positions = positions;
        }
        public void Place(Unit unit,int posId)
        {
            unit.transform.position = positions[posId];
        }
    }
}
