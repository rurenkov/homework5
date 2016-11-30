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
