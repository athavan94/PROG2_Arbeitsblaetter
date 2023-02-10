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
            TeamLeiter teamLeiter = new TeamLeiter();
            ProductOwner productOwner = new ProductOwner();
            Softwareentwickler softwareentwickler = new Softwareentwickler();

            teamLeiter.Name = "Marco Müller";
            productOwner.Name = "Nicola Schmid";
            softwareentwickler.Name = "Marcel Zimmermann";

            List<InformatikAbteilung> liste = new List<InformatikAbteilung>();

            liste.Add(teamLeiter);
            liste.Add(productOwner);
            liste.Add(softwareentwickler);

            foreach(InformatikAbteilung informatikAbteilung in liste)
            {
                informatikAbteilung.Vorstellen();
                informatikAbteilung.MeineAufgaben();

                Console.WriteLine();
            }
            */

            // AB1 Aufgabe 3

            LeiterFinanzen leiterFinanzen = new LeiterFinanzen();
            Verkäufer verkäufer = new Verkäufer();
            TeamLeiter3 teamLeiter = new TeamLeiter3();
            Softwareentwickler3 softwareentwickler = new Softwareentwickler3();

            leiterFinanzen.Name = "Cedric Meier";
            verkäufer.Name = "Arton Blasi";
            teamLeiter.Name = "Marco Müller";
            softwareentwickler.Name = "Marcel Zimmermann";

            List<IVorstellung> liste = new List<IVorstellung>();

            liste.Add(leiterFinanzen);
            liste.Add(verkäufer);
            liste.Add(teamLeiter);
            liste.Add(softwareentwickler);

            foreach(Abteilung abteilung in liste)
            {
                abteilung.Beschreibung();
                
                Console.WriteLine();
            }
        }
    }
}
