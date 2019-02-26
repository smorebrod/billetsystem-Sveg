using System;
using System.Linq.Expressions;

namespace BilletLibrary
{   /// <summary>
/// Basse Klasse for køretøjer. Prop og metoder er protected.
/// </summary>
    public abstract class BaseClassKøretøjer
    {
        /// <summary>
        /// Constructeren i basse klassen. (Nummerplade skrives som string)
        /// </summary>
        /// <param name="nummerplade"></param>
        protected BaseClassKøretøjer(string nummerplade)
        {
            NummerPlade = nummerplade;

        }

        /// <summary>
        /// Nummerplade prop med en get og set, nummerplade må ikke være på mere en 7 tegn.
        /// </summary>
        protected string NummerPlade
        {
            get { return NummerPlade; }
            set
            {
                if (NummerPlade.Length > 7)
                {
                    throw new Exception();
                }
            }
        }

        /// <summary>
        /// DateTIme har en get og set.
        /// </summary>
        protected DateTime Date { get; set; }

        /// <summary>
        /// metode for pris, er abstract så skal overrides i MC og Bil.
        /// </summary>
        /// <returns></returns>
        protected abstract decimal Pris();

        /// <summary>
        /// metode for køretøjer, er abstract så skal overrides i MC og Bil.
        /// </summary>
        /// <returns></returns>
        protected abstract string Køretøj();

        /// <summary>
        /// Metode for brobizz, er abstract så skal overrides i MC og Bil.
        /// </summary>
        /// <returns></returns>
        protected abstract double Brobizz();
    }
}