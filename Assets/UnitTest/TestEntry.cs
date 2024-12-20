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
    internal class TestEntry
    {
        private Entry ui;
        private GameObject clone;

        [SetUp]
        public void set()
        {
            clone = new GameObject();
            var uimap = new GameObject("positions");
            for (int i = 0; i < 3; i++)
            {
                var p = new GameObject(i.ToString());
                p.transform.SetParent(uimap.transform);
                p.transform.position = new Vector3(0, 0, i);
            }
            uimap.transform.SetParent(clone.transform);
            ui = new Entry();
            ui.dataFactroy = new TDataFactroy();
            ui.Start(clone.transform);
        }
        [Test]
        public void testMap()
        {
            var map = ui.game.map;
            Assert.AreEqual(3, map.Count);
            for (int i = 0; i < map.Count; i++)
            {
                var p = map[i];
                Assert.AreEqual(0, p.x);
                Assert.AreEqual(0, p.y);
                Assert.AreEqual(i, p.z);
            }
            Assert.AreEqual(3, ui.game.map.Count);
        }
        [Test]
        public void testData()
        {
            ui = new Entry();
            Assert.IsInstanceOf<DataFactroy>(ui.dataFactroy);
            var test = new TDataFactroy();
            ui.dataFactroy = test;
            ui.Start(clone.transform);
            Assert.AreSame(test.data,ui.game.dataBase);
            Assert.AreEqual(10, ui.game.player.unitCounts);
        }
        [Test]
        public void testNotify()
        {
            Assert.IsNull(ui.unitsView);
            Assert.AreSame(ui.viewCtrl, ui.game.notify);
            Assert.AreSame(ui.viewCtrl.mgr, ui.viewMgr);
        }
        [Test]
        public void testViewMgr()
        {
            Assert.IsInstanceOf<ViewMgr>(ui.viewMgr);
            Assert.NotNull(ui.viewMgr.Get<UnitsView>());
        }
    }
}
