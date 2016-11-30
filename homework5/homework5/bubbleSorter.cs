using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    public class BubbleSorter
    {

        private int[] Array;

        public BubbleSorter(int[] array)
        {
            this.Array = array;
        }


 

        //*******************************************************//
        // print method;
        //*******************************************************//


        public static void Print(int[] MYarray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MYarray));

        }

        //*******************************************************//
        // swap method;
        //*******************************************************//

        public static void Swap(ref int a, ref int b)   // need to fix it in order to work with indexes.

        {
            int tmp = 0;
            tmp = a;
            a = b;
            b = tmp;
        }


        //*******************************************************//
        // BuBBLE SORT
        //*******************************************************//



        public void Sort()   // sorting logic
        {

            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        BubbleSorter.Swap(ref Array[j - 1], ref Array[j]);
                    }
                }
            }
        }
    }

}