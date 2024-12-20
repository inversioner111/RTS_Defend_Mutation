using RTS;
using UnityEngine;

namespace UnitTest
{
    internal class TNotify : INotify
    {
        internal string log;

        public void OnCreateUnit(int id, int typeId,Vector3 pos)
        {
            log += $"create unit id:{id} type:{typeId} pos:{pos}";
        }
    }
}