using System;
using System.Collections.Generic;
using PROG2_Arbeitsblaetter.AB1_Aufgabe_2;
using PROG2_Arbeitsblaetter.AB1_Aufgabe_3;

namespace PROG2_Arbeitsblaetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // AB1 Aufgabe 1

            /*
            Console.WriteLine(Ueberladung.Plus(1,2)); //3
            Console.WriteLine(Ueberladung.Plus(1,2,3)); //6
            Console.WriteLine(Ueberladung.Plus(1,2,3,4)); //10
            */

            // AB1 Aufgabe 2

            /*
            TeamLeiterA2 teamLeiter = new TeamLeiterA2();
            ProductOwnerA2 productOwner = new ProductOwnerA2();
            SoftwareentwicklerA2 softwareentwickler = new SoftwareentwicklerA2();

            teamLeiter.Name = "Marco Müller";
            productOwner.Name = "Nicola Schmid";
            softwareentwickler.Name = "Marcel Zimmermann";

            List<InformatikAbteilungA2> liste = new List<InformatikAbteilungA2>();

            liste.Add(teamLeiter);
            liste.Add(productOwner);
            liste.Add(softwareentwickler);

            foreach(InformatikAbteilungA2 informatikAbteilung in liste)
            {
                informatikAbteilung.Vorstellen();
                informatikAbteilung.MeineAufgaben();

                Console.WriteLine();
            }
            */

            // AB1 Aufgabe 3

            /*
            LeiterFinanzenA3 leiterFinanzen = new LeiterFinanzenA3();
            VerkäuferA3 verkäufer = new VerkäuferA3();
            TeamLeiterA3 teamLeiter = new TeamLeiterA3();
            SoftwareentwicklerA3 softwareentwickler = new SoftwareentwicklerA3();

            leiterFinanzen.Name = "Cedric Meier";
            verkäufer.Name = "Arton Blasi";
            teamLeiter.Name = "Marco Müller";
            softwareentwickler.Name = "Marcel Zimmermann";

            List<IVorstellungA3> liste = new List<IVorstellungA3>();

            liste.Add(leiterFinanzen);
            liste.Add(verkäufer);
            liste.Add(teamLeiter);
            liste.Add(softwareentwickler);

            foreach(AbteilungA3 abteilung in liste)
            {
                abteilung.Beschreibung();
                
                Console.WriteLine();
            }
            */
        }
    }
}
