using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter
{
    /*
     * Erstellen Sie eine neue Klasse, die eine Methode enthält, welche in 3 Ausprägungen (3 Versionen) vorkommt durch Überladung. (Siehe Beispiel S. 3)
     */
    class AB1_Aufgabe1_Ueberladung
    {
        public static int Plus(int number1, int number2)
        {
            return Plus(number1, number2, 0);
        }

        public static int Plus(int number1, int number2, int number3)
        {
            return Plus(number1, number2, number3);
        }

        public static int Plus(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }
    }
}
