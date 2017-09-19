using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    /// <summary>
    /// Klasse til Biler
    /// </summary>
    public class Bil : KøreTøj
    {

        //protected const int GrundPris = 240;

        public override string KøreTøjType()
        {
            return "Bil";
        }


        //TODO Der skal laves en refaktorering så brobizz rabatten kodes i selvstændig metode
        /// <summary>
        /// Giver prisen på en overfart 
        /// Der gives 20% hvis datoen er en lørdag eller søndag
        /// Der gives 5% hvis der er en brobizz
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            int total = GrundPris;

            //ekstra 20 % pga lørdag eller søndag
            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
                total = total * 80 / 100; 


            if (BroBizz)
                return total * 95 / 100;

            return total;
        }

        //TODO Mangler en default constructor
        /// <summary>
        /// constructor
        /// </summary>
        public Bil()
         :base(240)
        {

        }

    }
}
