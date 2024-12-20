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
        private Table table;
        private Row row;
        private Player player;
        private Vector3[] map;
        private Game game;
        private UnitRepository unitRepository;

        [SetUp]
        public void set()
        {
            var database = new Database();
            table = new Table();
            row = new Row();
            row.Add("cost", 10);
            table.Add("1000", row);
            database.Add("units", table);
            player = new Player();
            player.unitCounts = 11;
            map = new Vector3[] 
            { 
                new Vector3(0, 0, 1),
                new Vector3(0, 0, 2),
                new Vector3(0, 0, 3)
            };
            game = new Game(database,player, map);
            unitRepository = game.unitRepository;
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
    }
}

