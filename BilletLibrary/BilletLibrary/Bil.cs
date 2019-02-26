using System;

namespace BilletLibrary
{   /// <summary>
/// Klassen bil arver fra BaseClassKøretøjer
/// </summary>
    public class Bil : BaseClassKøretøjer
    {
        /// <summary>
        /// Contructeren, nummerplade arver fra base(nummerplader)
        /// </summary>
        /// <param name="nummerplade"></param>
        public Bil(string nummerplade) : base(nummerplade)
        {
           
        }


        /// <summary>
        /// Metode for pris, skal overrides.
        /// </summary>
        /// <returns> Pris </returns>
        protected override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metode for køretøjer, skal overrides
        /// </summary>
        /// <returns> Køretøjs form </returns>
        protected override  string Køretøj()
        {
            return "Bil";
        }

        /// <summary>
        /// Metode for brobizz, skal overrides
        /// </summary>
        /// <returns> brobizz rabat </returns>
        protected override double Brobizz()
        {
            var Result = 240 * 0.95;
            return Result;
        }
    }
}
