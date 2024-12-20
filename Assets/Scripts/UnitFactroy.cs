using UnityEngine;

namespace RTS
{
    public class UnitFactroy
    {
        int seed = 0;
        public Unit NewUnit(int typeId)
        {
            var unit = new Unit();
            unit.Id = seed++;
            unit.TypeId = typeId;
            unit.transform = new GameObject().transform;
            return unit;
        }
    }
}
