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
                        Common.SWAP(ref Array[j - 1], ref Array[j]);
                    }
                }
            }
        }





    }
}