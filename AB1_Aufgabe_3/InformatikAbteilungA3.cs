using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_3
{
    abstract class InformatikAbteilungA3: AbteilungA3
    {
        public string ProjektName { get; set; }
    }

    class TeamLeiterA3 : InformatikAbteilungA3
    {
        public TeamLeiterA3()
        {
            this.Rolle = "Team Leiter";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und informiere über Neuigkeiten.");
        }
    }

    class ProductOwnerA3 : InformatikAbteilungA3
    {
        public ProductOwnerA3()
        {
            this.Rolle = "ProductOwner";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin verantwortlich für das Produkt und entscheide was entwickelt werden soll.");
        }
    }

    class SoftwareentwicklerA3 : InformatikAbteilungA3
    {
        public SoftwareentwicklerA3()
        {
            this.Rolle = "Softwareentwickler";
            this.ProjektName = "Webflow 4";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin für die Entwicklung des Produktes zuständig.");
            Console.WriteLine("Ich arbeite zur Zeit am Produkt " + ProjektName + ".");
        }
    }
}
