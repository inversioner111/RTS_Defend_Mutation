using UnityEngine;

namespace RTS
{
    public interface INotify
    {
        void OnCreateUnit(int id,int typeId, Vector3 pos);
    }
}
