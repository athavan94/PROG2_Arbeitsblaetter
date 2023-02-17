using System.Collections.Generic;

namespace PROG2_Arbeitsblaetter.AB2A_Aufgabe_7
{
    internal class Player
    {
        public Player() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Position { get; set; }
        public string Nationalität { get; set; }
        public ICollection<ManchesterUnited> ManchesterUnited { get; set; }
    }
}