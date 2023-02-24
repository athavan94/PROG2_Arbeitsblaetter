using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Controller
{
    internal class TeamController
    {
        public void CreateTeam()
        {
            Console.WriteLine("Geben Sie den Namen des Teams ein:");
            var name = Console.ReadLine();
            Console.WriteLine("Geben Sie eine Beschreibung für das Team ein:");
            var description = Console.ReadLine();

            using (var context = new Context())
            {
                Team newTeam = new Team() { Name = name, Description = description };
                context.Team.Add(newTeam);
                context.SaveChanges();
            }

            Console.WriteLine();
            Console.WriteLine("Team " + name + " wurde erfolgreich erstellt.");
            Console.WriteLine();
        }
    }
}
