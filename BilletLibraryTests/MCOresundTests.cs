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
    public class MCOresundTests
    {
        [TestMethod()]
        public void VehicleTypeTypeTest()
        {
            var mc = new MCOresund();

            Assert.AreEqual("Oresund MC",mc.VehicleType());
        }

        [TestMethod()]
        public void PriceTest()
        {
            var mc = new MCOresund();
            mc.BroBizz = false;
            Assert.AreEqual(210,mc.Price());
        }


        [TestMethod()]
        public void PriceBroBizzTest()
        {
            var mc = new MCOresund();
            mc.BroBizz = true;

            Assert.AreEqual(73, mc.Price());
        }

    }
}