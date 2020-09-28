using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {

        [TestMethod()]
        public void KøreTøjTypeTest()
        {
            var mc = new MC();
            Assert.AreEqual("MC", mc.VehicleType());

        }


        [TestMethod()]
        public void PrisTest()
        {
            var mc = new MC();
            Assert.AreEqual(125,mc.Price());
        }

        [TestMethod()]
        public void PrisBroBizzTest()
        {
            var mc = new MC();
            mc.BroBizz = true;
            Assert.AreEqual(118, mc.Price());
        }
    }
}