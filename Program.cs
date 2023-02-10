using System;
using System.Collections.Generic;
using PROG2_Arbeitsblaetter.AB1_Aufgabe_2;
using PROG2_Arbeitsblaetter.AB1_Aufgabe_3;
using PROG2_Arbeitsblaetter.AB1_Aufgabe_4;

namespace PROG2_Arbeitsblaetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // AB1 Aufgabe 4

            List<IVorstellungA4> liste = new List<IVorstellungA4>()
            {
                new LeiterFinanzenA4 {Name = "Cedric Meier", Age = 45},
                new VerkäuferA4 {Name = "Arton Blasi", Age = 28},
                new TeamLeiterA4 {Name = "Marco Müller", Age = 54},
                new ProductOwnerA4 {Name = "Nicola Schmid", Age = 46},
                new SoftwareentwicklerA4 {Name = "Marcel Zimmermann", Age = 28}
            };

            liste.Sort();

            foreach (AbteilungA4 abteilung in liste)
            {
                abteilung.Beschreibung();

                Console.WriteLine();
            }

            // AB1 Aufgabe 3

            /*
            List<IVorstellungA3> liste = new List<IVorstellungA3>()
            {
                new LeiterFinanzenA3 {Name = "Cedric Meier"},
                new VerkäuferA3 {Name = "Arton Blasi"},
                new TeamLeiterA3 {Name = "Marco Müller"},
                new SoftwareentwicklerA3 {Name = "Marcel Zimmermann"}
            };

            foreach(AbteilungA3 abteilung in liste)
            {
                abteilung.Beschreibung();
                
                Console.WriteLine();
            }
            */

            // AB1 Aufgabe 2

            /*
            List<InformatikAbteilungA2> liste = new List<InformatikAbteilungA2>()
            {
                new TeamLeiterA2 {Name = "Marco Müller"},
                new ProductOwnerA2 {Name = "Nicola Schmid"},
                new SoftwareentwicklerA2 {Name = "Marcel Zimmermann"}
            };

            foreach(InformatikAbteilungA2 informatikAbteilung in liste)
            {
                informatikAbteilung.Vorstellen();
                informatikAbteilung.MeineAufgaben();

                Console.WriteLine();
            }
            */

            // AB1 Aufgabe 1

            /*
            Console.WriteLine(Ueberladung.Plus(1,2)); //3
            Console.WriteLine(Ueberladung.Plus(1,2,3)); //6
            Console.WriteLine(Ueberladung.Plus(1,2,3,4)); //10
            */
        }
    }
}
