using System.Collections.Generic;

namespace RTS
{
    public class UnitRepository
    {
        private Dictionary<int, Unit> units = new Dictionary<int, Unit>();
        public int unitsCount => units.Count;
        public void Add(Unit unit)
        {
            units.Add(unit.Id, unit);
        }
        public Unit FindUnit(int id)
        {
            units.TryGetValue(id, out var unit);
            return unit;
        }
    }
}
