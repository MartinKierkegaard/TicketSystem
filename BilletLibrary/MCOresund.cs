using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    /// <summary>
    /// MC class used for Øresundsbroen
    /// </summary>
    public class MCOresund : Vehicle
    {
        private const int BroBizzPrice = 73;

        /// <summary>
        /// default ctor, price is 210 (baseprice) 
        /// </summary>
        public MCOresund() 
            : base(210)
        {
        }

        /// <summary>
        /// The type of the vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }

        /// <summary>
        /// The price for a journey, discount if brobizz is used
        /// </summary>
        /// <returns>Grundpris hhv. BroBizzPris</returns>
        public override int Price()
        {
            if (BroBizz)
                return BroBizzPrice;
            else
                return BasePrice;
        }
    }
}
