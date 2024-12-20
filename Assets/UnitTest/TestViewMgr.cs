using NUnit.Framework;
using RTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class TestViewMgr
    {
        [Test]
        public void testAdd()
        {
            var mgr = new ViewMgr();
            var test = new TView();
            mgr.Add(test);
            Assert.AreSame(test, mgr.Get<TView>());
        }
    }
}
