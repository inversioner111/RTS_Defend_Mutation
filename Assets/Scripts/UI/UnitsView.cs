using UnityEngine;
using System.Collections.Generic;
namespace RTS
{
    public class UnitsView:AView
    {
        public Dictionary<int, Transform> units { get; } = new Dictionary<int, Transform>();

        public void OnCreateUnit(int id, int typeId, Vector3 pos)
        {
           //var clone= loader.Instantiate<Transform>($"units/unit{typeId}");
           // clone.gameObject.AddComponent<Identiy>().value = id;
           // clone.position = pos;
           // units.Add(id, clone);
        }
    }
}