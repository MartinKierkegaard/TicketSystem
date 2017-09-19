using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{

    /// <summary>
    /// Alm MC klasse
    /// </summary>
    public class MC : KøreTøj
    {

        //private const int GrundPris = 125;

            /// <summary>
            /// angiver køretøjstypen
            /// </summary>
            /// <returns></returns>
        public override string KøreTøjType()
        {
            return "MC";
        }

        /// <summary>
        /// angiver prisen på en overfart, med rabat hvis der bruges broBizz
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            if (BroBizz)
                return GrundPris * 95 / 100;

            return GrundPris;
        }

        /// <summary>
        /// default ctor 
        /// sætter prisen til 125 
        /// </summary>
        public MC()
            :base(125)
        {

        }
    }
}
