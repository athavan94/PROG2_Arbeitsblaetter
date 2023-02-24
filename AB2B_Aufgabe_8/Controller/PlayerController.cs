using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Controller
{
    internal class PlayerController
    {
        public void CreatePlayer(Player newPlayer)
        {
            using(Context context = new Context())
            {
                context.Add(newPlayer);
                context.SaveChanges();
            }
        }

        public void ReadPlayer(string name) { }
        public void UpdatePlayer(Player player) { }
        public void DeletePlayer(Player player) { }

    }
}
