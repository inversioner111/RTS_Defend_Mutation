using UnityEngine;
namespace RTS
{
    public class ResLoader
    {
        public virtual T Load<T>(string path)where T:Object
        {
            return Resources.Load<T>(path);
        }
        public virtual T Instantiate<T>(string path) where T : Object
        {
            var prefab = Load<T>(path);
            return Object.Instantiate(prefab);
        }
    }
}