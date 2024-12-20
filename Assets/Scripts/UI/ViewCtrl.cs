using System;
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
            var view = mgr.Get<UnitsView>();
            var clone = mgr.loader.Instantiate<Transform>($"units/unit{typeId}");
            clone.gameObject.AddComponent<Identiy>().value = id;
            clone.position = pos;
            view.units.Add(id, clone);
        }

        public void OnUnitCountChange(int value)
        {
            
        }
    }
}