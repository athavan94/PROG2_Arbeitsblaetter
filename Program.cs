using System;
using System.Collections.Generic;
using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8;
using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Controller;
using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Model;

namespace PROG2_Arbeitsblaetter
{
    class Program
    {
        static List<Player> players = new List<Player>();

        static void Main(string[] args)
        {
            TeamController teamController = new TeamController();
            PlayerController playerController = new PlayerController();

            Console.WriteLine("AB2B Aufgabe 8");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Option aus:");
                Console.WriteLine("1 - Team erstellen");
                Console.WriteLine("2 - Spieler hinzufügen");
                Console.WriteLine("3 - Alle Teams anzeigen");
                Console.WriteLine("4 - Alle Spieler anzeigen");
                Console.WriteLine("5 - Team anpassen");
                Console.WriteLine("6 - Spieler anpassen");
                Console.WriteLine("7 - Spieler löschen");
                Console.WriteLine("8 - Team löschen");
                Console.WriteLine("9 - Beenden");
                Console.WriteLine();
                Console.Write("Option: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out var option))
                {
                    switch (option)
                    {
                        case 1:
                            teamController.CreateTeam();
                            break;
                        case 2:
                            playerController.CreatePlayer();
                            break;
                        case 3:
                            teamController.ShowAllTeams();
                            break;
                        case 4:
                            playerController.ShowAllPlayers();
                            break;
                        case 5:
                            teamController.UpdateTeam();
                            break;
                        case 6:
                            playerController.UpdatePlayer();
                            break;
                        case 7:
                            playerController.DeletePlayer();
                            break;
                        case 8:
                            teamController.DeleteTeam();
                            break;
                        case 9:
                            return;
                        default:
                            Console.WriteLine("Ungültige Option.");
                            break;
                    }
                } else
                {
                    Console.WriteLine("Ungültige Option.");
                }

            }
        }
    }
}
