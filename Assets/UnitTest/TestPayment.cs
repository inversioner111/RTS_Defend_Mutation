using NUnit.Framework;
using RTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class TestPayment
    {
        [Test]
        public void test()
        {
            var player = new Player();
            var table = new Table();
            var row = new Row();
            row.Add("cost", 1);
            table.Add("1", row);
            var pay = new Payment(table, player);
            Assert.IsFalse(pay.isPayed(1));
        }
    }
}
