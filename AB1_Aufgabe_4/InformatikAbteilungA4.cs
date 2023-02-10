using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_4
{
    abstract class InformatikAbteilungA4: AbteilungA4
    {
        public string ProjektName { get; set; }
    }

    class TeamLeiterA4 : InformatikAbteilungA4
    {
        public TeamLeiterA4()
        {
            Rolle = "Team Leiter";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und informiere über Neuigkeiten.");
        }
    }

    class ProductOwnerA4 : InformatikAbteilungA4
    {
        public ProductOwnerA4()
        {
            Rolle = "ProductOwner";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin verantwortlich für das Produkt und entscheide was entwickelt werden soll.");
        }
    }

    class SoftwareentwicklerA4 : InformatikAbteilungA4
    {
        public SoftwareentwicklerA4()
        {
            Rolle = "Softwareentwickler";
            ProjektName = "Webflow 4";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin für die Entwicklung des Produktes zuständig.");
            Console.WriteLine("Ich arbeite zur Zeit am Produkt " + ProjektName + ".");
        }
    }
}
