using System.Collections.Generic;

namespace PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Model
{
    internal class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Position { get; set; }
        public string Nationalität { get; set; }
        public ICollection<Team> Team { get; set; }
    }
}