using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_5
{
    abstract class AbteilungA5: IVorstellungA5
    {
        public string Name;
        public string Rolle;
        public int Age;

        public void Vorstellen()
        {
            Console.WriteLine("Mein Name ist " + Name + ".");
            Console.WriteLine("Ich bin ein " + Rolle + ".");
            Console.WriteLine("Ich bin " + Age + " alt.");
        }

        public abstract void Beschreibung();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            AbteilungA5 otherAbteilung = obj as AbteilungA5;
            if (otherAbteilung != null)
                return Age.CompareTo(otherAbteilung.Age);
            else
                throw new ArgumentException("Object is not a Abteilung");
        }
    }
}
