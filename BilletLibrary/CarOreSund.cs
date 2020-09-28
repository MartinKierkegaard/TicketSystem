using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    /// <summary>
    /// car class used for Oresundsbroen
    /// </summary>
    public class CarOreSund : Vehicle
    {

        private const int BroBizzPrice = 161;

        /// <summary>
        /// default ctor price is 410 (baseprice)
        /// </summary>
        public CarOreSund()
            :base(410)
        {
        }

        /// <summary>
        /// The type of the vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }

        public override int Price()
        {
            if (BroBizz)
                return BroBizzPrice;
            else
                return BasePrice;

        }
    }
}
