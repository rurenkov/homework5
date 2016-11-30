using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{

    //*******************************************************//
    // Insert SORT
    //*******************************************************//


    public class InsertionSorter
    {

        private int[] Array;

        public InsertionSorter(int[] array)   // конструктор маЄ бути названий так само як класс. Обовязково!!!
        {
            this.Array = array;
        }


      
    public static void Print(int[] MyArray)
    {

        Console.WriteLine("[{0}]", string.Join(", ", MyArray));

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
        // SORT
        //*******************************************************//


        public void Sort()   // sorting logic
        {
            for (int i = 1; i < Array.Length; i++)
            {
                for (int j = 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        InsertionSorter.Swap(ref Array[j - 1],ref Array[j]);
                        j--;
                    }
                }
            }
        }
    }

}