using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_5
{
    abstract class FinanzAbteilungA5: AbteilungA5
    {
        public int Erfahrung { get; set; }
    }

    class LeiterFinanzenA5 : FinanzAbteilungA5
    {
        public LeiterFinanzenA5()
        {
            Rolle = "Leiter Finanzen";
            Erfahrung = 5;
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und bin für den Umsatz der Firma verantwortlich.");
            Console.WriteLine("Ich habe " + Erfahrung + " Jahre.");
        }
    }

    class VerkäuferA5 : FinanzAbteilungA5
    {
        public VerkäuferA5()
        {
            Rolle = "Verkäufer";
            Erfahrung = 3;
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und bin für den Umsatz der Firma verantwortlich.");
            Console.WriteLine("Ich habe " + Erfahrung + " Jahre.");
        }
    }
}
