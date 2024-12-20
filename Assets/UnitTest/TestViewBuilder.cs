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
    internal class TestViewBuilder
    {
        [Test]
        public void test()
        {
            var loader = new TResLoader();
            var root = loader.Instantiate<Transform>("root");
            var builder = new ViewFactroy();
            var mgr = new ViewMgr();
            
        }
    }
}
