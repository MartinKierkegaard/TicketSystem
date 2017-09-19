using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{

    /// <summary>
    /// MC obj som skal bruges til Øresundsbroen
    /// </summary>
    public class MCØresund : KøreTøj
    {
        private const int BroBizzPris = 73;

        /// <summary>
        /// default ctor som sætter prisen til 210
        /// </summary>
        public MCØresund() 
            : base(210)
        {
        }

        /// <summary>
        /// Angiver køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string KøreTøjType()
        {
            return "Øresund MC";
        }

        /// <summary>
        /// Angiver prisen på en overfart, med rabat hvis der bruges broBizz
        /// </summary>
        /// <returns>Grundpris hhv. BroBizzPris</returns>
        public override int Pris()
        {
            if (BroBizz)
                return BroBizzPris;
            else
                return GrundPris;
        }
    }
}
