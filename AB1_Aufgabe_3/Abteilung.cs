using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_3
{
    abstract class Abteilung: IVorstellung
    {
        public string Name;
        public string Rolle;

        public void Vorstellen()
        {
            Console.WriteLine("Mein Name ist " + Name + ".");
            Console.WriteLine("Ich bin ein " + Rolle + ".");
        }

        public abstract void Beschreibung();
    }
}
