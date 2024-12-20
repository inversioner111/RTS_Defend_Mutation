using System.Collections.Generic;

namespace RTS
{
    public class ViewMgr
    {
        Dictionary<string, AView> dics = new Dictionary<string, AView>();

        public ResLoader loader { get; set; } = new ResLoader();

        public void Add(AView view)
        {
            view.loader = loader;
            dics.Add(view.GetType().ToString(), view);
        }
        public T Get<T>()where T:AView
        {
            dics.TryGetValue(typeof(T).ToString(), out var view);
            return view as T;
        }
    }
}