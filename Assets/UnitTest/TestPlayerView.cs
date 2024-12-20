using NUnit.Framework;
using RTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    internal class TestPlayerView
    {
        [Test]
        public void test()
        {
            var view = new PlayerView();
            Assert.AreEqual("unitCountTxt", view.unitCountTxt.name);
        }
    }
}
