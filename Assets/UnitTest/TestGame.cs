using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using RTS;
using UnityEngine;
using UnityEngine.TestTools;
namespace UnitTest
{
    public class TestGame
    {
        private Database database;
        private Table table;
        private Row row;
        private Player player;
        private Vector3[] map;
        private Game game;
        private UnitRepository unitRepository;

        [SetUp]
        public void set()
        {
            database = new TDataFactroy().Factroy();
            table = database.Get("units");
            row = table.Get("1000");
           
            map = new Vector3[] 
            { 
                new Vector3(0, 0, 1),
                new Vector3(0, 0, 2),
                new Vector3(0, 0, 3)
            };
            game = new Game(database, map);
            unitRepository = game.unitRepository;
            player = game.player;
            game.Start();
            player.unitCounts = 11;
        }
        [Test]
        public void testNew()
        {
            Assert.AreSame(game.dataBase, database);
        }
        [Test]
        public void testStart()
        {
            game.Start();
            Assert.AreEqual(10, player.unitCounts);
        }
        [Test]
        public void testCreateUnit()
        {
            var result = game.CreateUnit(1000, 1);
            Assert.IsTrue(result);
            Assert.AreEqual(1, unitRepository.unitsCount);
            var unit = unitRepository.FindUnit(0);
            Assert.AreEqual(0, unit.Id);
            Assert.AreEqual(1000, unit.TypeId);
            Assert.AreEqual(0 , unit.transform.position.x);
            Assert.AreEqual(0, unit.transform.position.y);
            Assert.AreEqual(2, unit.transform.position.z);
        }
        [Test]
        public void testCreateUnitCost()
        {
            game.CreateUnit(1000, 0);
            Assert.AreEqual(1, player.unitCounts);
        }
        [Test]
        public void testCreateUnitId()
        {
            player.unitCounts = 30;
            game.CreateUnit(1000, 1);
            game.CreateUnit(1000, 2);
            Assert.AreEqual(2, unitRepository.unitsCount);
            var unit = unitRepository.FindUnit(1);
            Assert.AreEqual(1, unit.Id);
        }
        [Test]
        public void testCreateUnitCondition()
        {
            player.unitCounts = 9;
            var result = game.CreateUnit(1000, 0);
            Assert.IsFalse(result);
            Assert.AreEqual(0, unitRepository.unitsCount);
            var unit = unitRepository.FindUnit(0);
            Assert.IsNull(unit);
        }
        [Test]
        public void testNotCreateOnOnePos()
        {
            player.unitCounts = 10000;
            game.CreateUnit(1000, 0);
            var result = game.CreateUnit(1000, 0);
            Assert.IsFalse(result);
            Assert.AreEqual(10000-10, player.unitCounts);
        }
        [Test]
        public void testNotify()
        {
            var notify = new TNotify();
            game.notify = notify;
            game.CreateUnit(1000, 0);
            Assert.AreEqual($"create unit id:0 type:1000 pos:{new Vector3(0,0,1)}", notify.log);
        }
    }
}

