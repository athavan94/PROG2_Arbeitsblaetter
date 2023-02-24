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
                Console.WriteLine("5 - Spieler löschen");
                Console.WriteLine("6 - Team löschen");
                Console.WriteLine("7 - Team anpassen");
                Console.WriteLine("8 - Spieler anpassen");
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
                            playerController.DeletePlayer();
                            break;
                        case 6:
                            //LöscheTeam();
                            break;
                        case 7:
                            //PasseTeamAn();
                            break;
                        case 8:
                            //PasseSpielerAn();
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

        static void AddPlayer()
        {
            Console.WriteLine();
            Console.WriteLine("Bitte geben Sie die Daten des neuen Spielers ein:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Vorname: ");
            string vorname = Console.ReadLine();
            Console.Write("Position: ");
            string position = Console.ReadLine();
            Console.Write("Nationalität: ");
            string nationalitaet = Console.ReadLine();

            Player newPlayer = new Player()
            {
                Name = name,
                Vorname = vorname,
                Position = position,
                Nationalität = nationalitaet
            };

            PlayerController playerController = new PlayerController();
            //playerController.CreatePlayer(newPlayer);

            Console.WriteLine();
            Console.WriteLine("Spieler wurde erfolgreich hinzugefügt.");
            Console.WriteLine();
        }
    }
}
