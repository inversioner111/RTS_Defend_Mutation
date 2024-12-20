using RTS;
using UnityEngine;

namespace UnitTest
{
    internal class TViewFactroy : ViewFactroy
    {
        public ViewCtrl ctrl=new ViewCtrl(default);
        internal object tran;

        public override ViewCtrl Factroy(Transform transform)
        {
            tran = transform;
            return ctrl;
        }
    }
}