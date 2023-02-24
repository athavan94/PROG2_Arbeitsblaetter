using Microsoft.EntityFrameworkCore;
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

            using (Context context = new Context())
            {
                Team team = context.FindTeamByName(teamName);
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
                    Console.WriteLine("Spieler {0} wurde erstellt.", name);
                }
                else
                {
                    Console.WriteLine("Team mit dem Namen {0} wurde nicht gefunden.", teamName);
                }
            }
            Console.WriteLine();
        }

        public void ShowAllPlayers()
        {
            Console.WriteLine();
            using (Context context = new Context())
            {
                List<Player> players = context.Player.Include(p => p.Team).ToList();
                if (players.Any())
                {
                    Console.WriteLine("Alle Spieler:");
                    foreach (Player player in players)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Vorname: {2}, Position: {3}, Nationalität: {4}, Team: {5}",
                            player.ID,
                            player.Name,
                            player.Vorname,
                            player.Position,
                            player.Nationalität,
                            player.Team?.Name ?? "Kein Team");
                    }
                }
                else
                {
                    Console.WriteLine("Keine Spieler gefunden.");
                }
            }
            Console.WriteLine();
        }

        public void DeletePlayer()
        {
            Console.WriteLine();
            Console.WriteLine("Geben Sie den Namen des zu löschenden Spielers ein:");
            string name = Console.ReadLine();

            using (Context context = new Context())
            {
                Player player = context.FindPlayerByName(name);
                if (player != null)
                {
                    context.Player.Remove(player);
                    context.SaveChanges();
                    Console.WriteLine("Spieler mit dem Namen {0} wurde gelöscht.", player.Name);
                }
                else
                {
                    Console.WriteLine("Spieler mit dem Namen {0} wurde nicht gefunden.", player.Name);
                }
            }
            Console.WriteLine();
        }
    }
}
