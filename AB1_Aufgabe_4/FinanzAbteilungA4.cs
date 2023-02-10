using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_4
{
    abstract class FinanzAbteilungA4: AbteilungA4
    {
        public int Erfahrung { get; set; }
    }

    class LeiterFinanzenA4 : FinanzAbteilungA4
    {
        public LeiterFinanzenA4()
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

    class VerkäuferA4 : FinanzAbteilungA4
    {
        public VerkäuferA4()
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
