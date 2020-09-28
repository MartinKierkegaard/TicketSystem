using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    /// <summary>
    /// baseclass for all MC and Car classes
    /// Vehicle is an abstract class
    /// </summary>
    public abstract class Vehicle
    {
        private string licenseplate;

        public string Licenseplate
        {
            get { return licenseplate; }
            set {
                if (value.Length > 7)
                    throw new ArgumentException("Licenseplate may only contain a max of 7 characters");
                
                licenseplate = value;
            }
        }


        public DateTime Date { get; set; }

        /// <summary>
        /// true if the customer use a BroBizz
        /// </summary>
        public bool BroBizz { get; set; }

        /// <summary>
        /// this method implements the calculation of the price with discounts
        /// </summary>
        /// <returns></returns>
        public abstract int Price();

        /// <summary>
        /// This method returns the type of the Vehicle
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

        protected int BasePrice { get; }

        /// <summary>
        /// ctor 
        /// </summary>
        /// <param name="basePrice">the baseprice for the vehicle</param>
        public Vehicle(int basePrice)
        {
            this.BasePrice = basePrice;
        }

    }
}
