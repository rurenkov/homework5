using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Common
    {
        //*******************************************************//
        // swap method;
        //*******************************************************//

        public static void SWAP(ref int a, ref int b)   // need to fix it in order to work with indexes.

        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;
        }
        //*******************************************************//
        // print method;
        //*******************************************************//


        public static void PrintArray(int[] MYarray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MYarray));

        }

        //*******************************************************//
        // Parce method;
        //*******************************************************//

        public static void ParceD(ref int d)
        {
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Try again..");
            }
        }





    }
}
