using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    /// <summary>
    /// The Car class is used for cars at the storebælts broen
    /// </summary>
    public class Car : Vehicle
    {

        /// <summary>
        /// The type of the vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }


        /// <summary>
        /// Calculate the price for one jouney 
        /// -20% discount if the day is Saturday or Sunday
        /// -5% discount if a brobizz is used
        /// </summary>
        /// <returns></returns>
        public override int Price()
        {
            int total = BasePrice;

            //extra 20 % discount if Saturday or Sunday
            if (base.Date.DayOfWeek == DayOfWeek.Saturday || base.Date.DayOfWeek == DayOfWeek.Sunday)
                total = total * 80 / 100; 

            //extra 5% if also brobizz
            if (BroBizz)
                return total * 95 / 100;

            return total;
        }


        /// <summary>
        /// default constructor price is 240 (baseprice)
        /// </summary>
        public Car()
         :base(240)
        {

        }

    }
}
