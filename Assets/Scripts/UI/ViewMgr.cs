using System.Collections.Generic;

namespace RTS
{
    public class ViewMgr
    {
        Dictionary<string, AView> dics = new Dictionary<string, AView>();
        public void Add(AView view)
        {
            dics.Add(view.GetType().ToString(), view);
        }
        public object Get<T>()
        {
            dics.TryGetValue(typeof(T).ToString(), out var view);
            return view;
        }
    }
}