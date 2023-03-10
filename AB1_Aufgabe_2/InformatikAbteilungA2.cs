using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_2
{
    abstract class InformatikAbteilungA2
    {
        public string Name { get; set; }
        public string Rolle { get; set; }
        private string Firma { get; set; } //Verstehe nicht für was diese private Methode gut sein soll. -> ABKLÄHREN

        public InformatikAbteilungA2()
        {
            Firma = "FIVE Informatik AG";
            Console.WriteLine(Firma);
        }

        /// <summary>
        /// Diese Methode muss überschrieben werden.
        /// </summary>
        public abstract void MeineAufgaben();

        /// <summary>
        /// Diese Methode kann bei der Vererbung überschreiben werden.
        /// </summary>
        public virtual void Vorstellen()
        {
            Console.WriteLine("Mein Name ist " + Name + ".");
            Console.WriteLine("Ich bin ein " + Rolle + ".");
        }
    }

    class TeamLeiterA2 : InformatikAbteilungA2
    {
        public TeamLeiterA2()
        {
            this.Rolle = "Team Leiter";
        }

        public override void Vorstellen()
        {
            Console.WriteLine();
            Console.WriteLine("Bitte stellt euch alle kurz vor.");
            Console.WriteLine();
            base.Vorstellen();
        }

        public override void MeineAufgaben()
        {
            Console.WriteLine("Ich führe das Team und informiere über Neuigkeiten.");
        }
    }

    class ProductOwnerA2 : InformatikAbteilungA2
    {
        public ProductOwnerA2()
        {
            this.Rolle = "ProductOwner";
        }

        public override void MeineAufgaben()
        {
            Console.WriteLine("Ich bin verantwortlich für das Produkt und entscheide was entwickelt werden soll.");
        }
    }

    class SoftwareentwicklerA2 : InformatikAbteilungA2
    {
        public SoftwareentwicklerA2()
        {
            this.Rolle = "Softwareentwickler";
        }

        public override void MeineAufgaben()
        {
            Console.WriteLine("Ich bin für die Entwicklung des Produktes zuständig.");
        }
    }
}
