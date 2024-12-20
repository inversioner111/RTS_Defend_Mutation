using UnityEngine;

namespace RTS
{
    public class ViewCtrl:INotify
    {
        public ViewCtrl(ViewMgr viewMgr)
        {
            this.mgr = viewMgr;
        }
        public ViewMgr mgr { get; set; }

        public void OnCreateUnit(int id, int typeId, Vector3 pos)
        {
            
        }
    }
}