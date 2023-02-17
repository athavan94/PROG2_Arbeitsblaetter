using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB2A_Aufgabe_6
{
    internal class Kunde
    {
        public int ID { get; set; }
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Ortschaft { get; set; }
        public int LieferkostenID { get; set; }
        public Lieferkosten Lieferkosten { get; set; }
    }
}
