using System.Collections.Generic;

namespace PROG2_Arbeitsblaetter.AB2A_Aufgabe_6
{
    internal class Lieferkosten
    {
        public Lieferkosten() { }
        public int ID { get; set; }
        public string NameZone { get; set; }
        public float Preis { get; set; }
        public ICollection<Kunde> Kunden { get; set; }
    }
}