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
            Console.WriteLine();
            Console.WriteLine("Geben Sie den Namen des Teams ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Geben Sie eine Beschreibung für das Team ein:");
            string beschreibung = Console.ReadLine();

            using (var context = new Context())
            {
                Team newTeam = new Team() { Name = name, Description = beschreibung };
                context.Team.Add(newTeam);
                context.SaveChanges();
            }

            Console.WriteLine();
            Console.WriteLine("Team {0} wurde erfolgreich erstellt.", name);
            Console.WriteLine();
        }

        public void ShowAllTeams()
        {
            using (var context = new Context())
            {
                Console.WriteLine();
                var teams = context.Team.ToList();
                if (teams.Any())
                {
                    Console.WriteLine("Alle Teams:");
                    foreach (var team in teams)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Beschreibung: {2}", team.ID, team.Name, team.Description);
                    }
                }
                else
                {
                    Console.WriteLine("Keine Teams gefunden.");
                }
                Console.WriteLine();
            }
        }
    }
}
