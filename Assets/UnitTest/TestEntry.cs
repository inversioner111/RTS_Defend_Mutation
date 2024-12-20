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
        private TViewFactroy viewFactroy;
        private TDataFactroy dataFactroy;

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
            ui = clone.AddComponent<Entry>();
            ui.enabled = false;
            dataFactroy = new TDataFactroy();
            ui.dataFactroy = dataFactroy;
            viewFactroy = new TViewFactroy();
            ui.viewFactroy = viewFactroy;
            ui.Start();
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
        public void testStart()
        {
            Assert.AreSame(dataFactroy.data, ui.game.dataBase);
            Assert.AreSame(viewFactroy.ctrl, ui.game.notify);
            Assert.AreSame(viewFactroy.tran,clone.transform);
            Assert.AreEqual(10, ui.game.player.unitCounts);
        }
        [Test]
        public void testNew()
        {
            ui = clone.AddComponent<Entry>();
            ui.enabled = false;
            Assert.IsInstanceOf<DataFactroy>(ui.dataFactroy);
            Assert.IsInstanceOf<ViewFactroy>(ui.viewFactroy);
        }
    }
}
