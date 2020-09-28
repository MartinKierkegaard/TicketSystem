using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{

    /// <summary>
    /// MC class used for Storbæls broen
    /// </summary>
    public class MC : Vehicle
    {

        //private const int BasePrice = 125;

        /// <summary>
        /// The type of the vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

        /// <summary>
        /// Price of a journey, if Brobizz there is a discount
        /// </summary>
        /// <returns></returns>
        public override int Price()
        {
            if (BroBizz)
                return BasePrice * 95 / 100;

            return BasePrice;
        }

        /// <summary>
        /// default ctor , the price is 125 (baseprice)
        /// </summary>
        public MC()
            :base(125)
        {

        }
    }
}
