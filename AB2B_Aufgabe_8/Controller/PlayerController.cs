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
        public void CreatePlayer()
        {
            Console.WriteLine();
            Console.WriteLine("Geben Sie den Namen des Spielers ein:");
            string name = Console.ReadLine();
            Console.WriteLine("Geben Sie den Vornamen des Spielers ein:");
            string vorname = Console.ReadLine();
            Console.WriteLine("Geben Sie die Position des Spielers ein:");
            string position = Console.ReadLine();
            Console.WriteLine("Geben Sie die Nationalität des Spielers ein:");
            string nationalität = Console.ReadLine();
            Console.WriteLine("Geben Sie den Namen des Teams ein:");
            string teamName = Console.ReadLine();

            using (var context = new Context())
            {
                Team team = context.FindByName(teamName);
                if (team != null)
                {
                    Player newPlayer = new Player()
                    {
                        Name = name,
                        Vorname = vorname,
                        Position = position,
                        Nationalität = nationalität,
                        TeamID = team.ID
                    };

                    context.Player.Add(newPlayer);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Team mit dem Namen {0} wurde nicht gefunden.", teamName);
                }
            }
        }

    }
}
