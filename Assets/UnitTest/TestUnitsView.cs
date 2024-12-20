using NUnit.Framework;
using RTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnitTest
{
    internal class TestUnitsView
    {
        [Test]
        public void test()
        {
            var loader = new TResLoader();
            var ui = new UnitsView();
            Assert.IsNull(ui.loader);
            ui.OnCreateUnit(0, 1, new Vector3(0,0,1));
            Assert.IsNull(loader.log);
        }
    }
}
