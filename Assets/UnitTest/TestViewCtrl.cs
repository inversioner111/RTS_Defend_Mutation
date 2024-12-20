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
    internal class TestViewCtrl
    {
        [Test]
        public void testUnits()
        {
            var mgr = new ViewMgr();
            var loader = new TResLoader();
            Assert.IsInstanceOf<ResLoader>(mgr.loader);
            mgr.loader = loader;
            var ui = new UnitsView();
            mgr.Add(ui);
            var ctrl = new ViewCtrl(mgr);
            ctrl.OnCreateUnit(0, 1, new Vector3(0, 0, 1));
            Assert.AreEqual("instanseload:units/unit1", loader.log);
            Assert.AreEqual("unit1(Clone)", ui.units[0].name);
            Assert.AreEqual(new Vector3(0, 0, 1), ui.units[0].position);
            Assert.AreEqual(0, ui.units[0].GetComponent<Identiy>().value);
        }
        [Test]
        public void testPlayerView()
        {
            var mgr = new ViewMgr();
            var loader = new TResLoader();
            Assert.IsInstanceOf<ResLoader>(mgr.loader);
            mgr.loader = loader;
            var ui = new PlayerView();
            mgr.Add(ui);
            var ctrl = new ViewCtrl(mgr);
            ctrl.OnUnitCountChange(10);
            Assert.AreEqual(10, ui.unitCountTxt.text);
        }
    }
}
