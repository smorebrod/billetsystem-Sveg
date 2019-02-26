using System;

namespace BilletLibrary
{
    /// <summary>
    /// Klassen MC arver fra BaseClassKøretøjer
    /// </summary>
    public class MC : BaseClassKøretøjer
    {
        /// <summary>
        /// Contructeren, nummerplade arver fra base(nummerplader)
        /// </summary>
        /// <param name="nummerplade"></param>
        public MC(string nummerplade) : base(nummerplade)
        {
            
        }

        /// <summary>
        /// Metode for pris, skal overrides.
        /// </summary>
        /// <returns> Pris </returns>
        protected override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Metode for køretøjer, skal overrides
        /// </summary>
        /// <returns> Køretøjs form </returns>
        protected override string Køretøj()
        {
            return "MC";
        }

        /// <summary>
        /// Metode for brobizz, skal overrides
        /// </summary>
        /// <returns> brobizz rabat </returns>
        protected override double Brobizz()
        {
            var Result = 125 * 0.95;
            return Result;
        }
    }
}