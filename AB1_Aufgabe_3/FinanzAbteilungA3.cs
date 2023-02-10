using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_3
{
    abstract class FinanzAbteilungA3: AbteilungA3
    {
        public int Erfahrung { get; set; }
    }

    class LeiterFinanzenA3 : FinanzAbteilungA3
    {
        public LeiterFinanzenA3()
        {
            this.Rolle = "Leiter Finanzen";
            this.Erfahrung = 5;
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und bin für den Umsatz der Firma verantwortlich.");
            Console.WriteLine("Ich habe " + Erfahrung + " Jahre.");
        }
    }

    class VerkäuferA3 : FinanzAbteilungA3
    {
        public VerkäuferA3()
        {
            this.Rolle = "Verkäufer";
            this.Erfahrung = 3;
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und bin für den Umsatz der Firma verantwortlich.");
            Console.WriteLine("Ich habe " + Erfahrung + " Jahre.");
        }
    }
}
