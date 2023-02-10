using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_5
{
    abstract class InformatikAbteilungA5: AbteilungA5
    {
        public string ProjektName { get; set; }
    }

    class TeamLeiterA5 : InformatikAbteilungA5
    {
        public TeamLeiterA5()
        {
            Rolle = "Team Leiter";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und informiere über Neuigkeiten.");
        }
    }

    class ProductOwnerA5 : InformatikAbteilungA5
    {
        public ProductOwnerA5()
        {
            Rolle = "ProductOwner";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin verantwortlich für das Produkt und entscheide was entwickelt werden soll.");
        }
    }

    class SoftwareentwicklerA5 : InformatikAbteilungA5
    {
        public SoftwareentwicklerA5()
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
