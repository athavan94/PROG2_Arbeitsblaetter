using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB1_Aufgabe_4
{
    abstract class AbteilungA4: IVorstellungA4
    {
        public string Name;
        public string Rolle;
        public DateTime date;

        public void Vorstellen()
        {
            Console.WriteLine("Mein Name ist " + Name + ".");
            Console.WriteLine("Ich bin ein " + Rolle + ".");
            Console.WriteLine("Ich habe am " + date.ToString("dd.MM.yyyy") + " Geburtstag.");
        }

        public abstract void Beschreibung();

        public int CompareTo(DateTime other)
        {
            return date.CompareTo(other);
        }
    }
}
