using System;

namespace RTS
{
    public class ViewMgr
    {
        UnitsView view = new UnitsView();
        public object Get<T>()
        {
            return view;
        }
    }
}