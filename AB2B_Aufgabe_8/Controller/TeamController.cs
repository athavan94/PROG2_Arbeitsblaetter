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

            using (Context context = new Context())
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
            using (Context context = new Context())
            {
                Console.WriteLine();
                List<Team> teams = context.Team.ToList();
                if (teams.Any())
                {
                    Console.WriteLine("Alle Teams:");
                    foreach (Team team in teams)
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

        public void DeleteTeam()
        {
            Console.WriteLine();
            Console.WriteLine("Geben Sie den Namen des zu löschenden Teams ein:");
            string name = Console.ReadLine();

            using (Context context = new Context())
            {
                Team team = context.FindTeamByName(name);
                if (team != null)
                {
                    context.Team.Remove(team);
                    context.SaveChanges();
                    Console.WriteLine("Team mit dem Namen {0} wurde gelöscht.", team.Name);
                }
                else
                {
                    Console.WriteLine("Team mit dem Namen {0} wurde nicht gefunden.", team.Name);
                }
            }
            Console.WriteLine();
        }
    }
}
