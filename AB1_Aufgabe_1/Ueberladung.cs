using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter
{
    class Ueberladung
    {
        public static int Plus(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Plus(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        public static int Plus(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }
    }
}
