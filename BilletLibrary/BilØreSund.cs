using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    /// <summary>
    /// bil obj. som bruges til Øresundsbroen
    /// </summary>
    public class BilØreSund : KøreTøj
    {

        private const int BroBizzPris = 161;

        /// <summary>
        /// default ctor prisen sættes til 410
        /// </summary>
        public BilØreSund()
            :base(410)
        {

        }

        /// <summary>
        /// angiver køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string KøreTøjType()
        {
            return "Øresund Bil";
        }

        public override int Pris()
        {
            if (BroBizz)
                return BroBizzPris;
            else
                return GrundPris;

        }
    }
}
