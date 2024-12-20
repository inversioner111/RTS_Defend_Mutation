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
            Assert.IsInstanceOf<ResLoader>(ui.loader);
            ui.loader = loader;
            ui.OnCreateUnit(0, 1, new Vector3(0,0,1));
            Assert.AreEqual("instanseload:units/unit1", loader.log);
            Assert.AreEqual("unit1(Clone)", ui.units[0].name);
            Assert.AreEqual(new Vector3(0, 0, 1), ui.units[0].position);
            Assert.AreEqual(0, ui.units[0].GetComponent<Identiy>().value);
        }
    }
}
