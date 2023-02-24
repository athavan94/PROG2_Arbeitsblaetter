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
            bool continueProgram = true;

            Console.WriteLine("AB2B Aufgabe 8");
            Console.WriteLine();

            while (continueProgram)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1 - Alle Spieler anzeigen");
                Console.WriteLine("2 - Spieler hinzufügen");
                Console.WriteLine("3 - Spieler löschen");
                Console.WriteLine("4 - Spieler aktualisieren");
                Console.WriteLine("5 - Programm beenden");
                Console.WriteLine();
                Console.Write("Aktion: ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        //ShowAllPlayers();
                        break;
                    case "2":
                        AddPlayer();
                        break;
                    case "3":
                        //DeletePlayer();
                        break;
                    case "4":
                        //UpdatePlayer();
                        break;
                    case "5":
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie eine gültige Option aus.");
                        break;
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
            playerController.CreatePlayer(newPlayer);

            Console.WriteLine();
            Console.WriteLine("Spieler wurde erfolgreich hinzugefügt.");
            Console.WriteLine();
        }
    }
}
