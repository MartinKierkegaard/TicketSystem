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
    public class CarTests
    {
        [TestMethod()]
        public void VehicleTypeTest()
        {
            var car = new Car();
            Assert.AreEqual("Car", car.VehicleType());
        }

        [TestMethod()]
        public void PriceTest()
        {
            var car = new Car();
            Assert.AreEqual(240, car.Price());
        }

        /// <summary>
        /// test if an exception is thrown if the licenspalte is 8 chars long
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void LicensePlate8CharTest()
        {
            var bil = new Car();

            bil.Licenseplate = "AB123456";

        }

        /// <summary>
        /// test if not throwing an exception if the licenseplate is 7 chars long
        /// </summary>
        [TestMethod()]
        public void LicensePlate7CharTest()
        {
            //Arrange
            var car = new Car();
            //Act
            car.Licenseplate = "AB12345";
            //Assert
            Assert.AreEqual("AB12345", car.Licenseplate);
        }

        [TestMethod()]
        public void PrisBroBizzTest()
        {
            var car = new Car();
            car.BroBizz = true;
            car.Date = new DateTime(2017, 8, 28);
            Assert.AreEqual(228, car.Price());
        }

        [TestMethod()]
        public void PrieSaturdayTest()
        {
            var car = new Car();
            car.BroBizz = false;
            car.Date = new DateTime(2017, 8, 26);
            Assert.AreEqual(192, car.Price());
        }

        [TestMethod()]
        public void PriceSundayTest()
        {
            var car = new Car();
            car.BroBizz = false;
            car.Date = new DateTime(2017, 8, 27);
            Assert.AreEqual(192, car.Price());
        }

        [TestMethod()]
        public void PriceMondayTest()
        {
            var car = new Car();
            car.BroBizz = false;
            car.Date = new DateTime(2017, 8, 28);
            Assert.AreEqual(240, car.Price());
        }

    }
}