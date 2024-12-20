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
    internal class TestMap
    {
        [Test]
        public void testMap()
        {
            var map = new Map(new Vector3[]
            {
                new Vector3(0,0,1),
                new Vector3(0,0,2),
                new Vector3(0,0,3),
            });
            Assert.AreEqual(3, map.Count);
            var tran = new GameObject().transform;
            map.Place(tran,0);
            Assert.AreEqual(0, tran.position.x);
            Assert.AreEqual(0, tran.position.y);
            Assert.AreEqual(1, tran.position.z);
        }
    }
}
