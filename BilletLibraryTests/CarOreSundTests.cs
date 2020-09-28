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
    public class CarOreSundTests
    {

        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new CarOreSund();
            Assert.AreEqual("Oresund Car", car.VehicleType());

        }

        [TestMethod()]
        public void PriceTest()
        {
            var car = new CarOreSund();
            car.BroBizz = false;

            Assert.AreEqual(410, car.Price());
        }


        [TestMethod()]
        public void PriceBroBizzTest()
        {
            var car = new CarOreSund();
            car.BroBizz = true;

            Assert.AreEqual(161, car.Price());
        }


    }
}