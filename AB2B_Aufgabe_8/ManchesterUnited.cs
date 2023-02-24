using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB2B_Aufgabe_8
{
    internal class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlayerID { get; set; }
        public Player Player { get; set; }
    }
}
