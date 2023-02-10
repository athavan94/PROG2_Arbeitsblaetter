using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_3
{
    abstract class InformatikAbteilung: Abteilung
    {
        public string ProjektName { get; set; }
    }

    class TeamLeiter3 : InformatikAbteilung
    {
        public TeamLeiter3()
        {
            this.Rolle = "Team Leiter";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich führe das Team und informiere über Neuigkeiten.");
        }
    }

    class ProductOwner3 : InformatikAbteilung
    {
        public ProductOwner3()
        {
            this.Rolle = "ProductOwner";
        }

        public override void Beschreibung()
        {
            Vorstellen();
            Console.WriteLine("Ich bin verantwortlich für das Produkt und entscheide was entwickelt werden soll.");
        }
    }

    class Softwareentwickler3 : InformatikAbteilung
    {
        public Softwareentwickler3()
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
