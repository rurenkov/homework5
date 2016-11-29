using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //*******************************************************//
            // BuBBLE SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******buble************");

            int[] array1 = new int[] { 5, 4, 1, 9, 1 };

            BubbleSorter bubbleSorter = new BubbleSorter(array1);  ///создаем нову переменну bubbleSorter з типом ВubbleSorter 
            Common.PrintArray(array1);
            bubbleSorter.Sort();    // визов метода Sort,з класса бабл сортер, передача йому значень масива для сортування.
                                    // він приймає значення, біжить по коду і результат друкуєм в тілі програми.
            Common.PrintArray(array1);

            //*******************************************************//
            // INSERTING SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******insert************");
            int[] array2 = new int[] { 9, 6, 3, 1, 4 };

            InsertionSorter insertionSorter = new InsertionSorter(array2);
            Common.PrintArray(array2);
            insertionSorter.Sort();
            Common.PrintArray(array2);

            //*******************************************************//
            // CIrcular Q
            //*******************************************************//


            int Buffsize = 0;
            int put = 0;
            int head = 0;
            int tail = 0;


            Console.WriteLine("Enter the size of an stack");
            Common.ParceD(ref Buffsize);            // parce size of stack
            int[] buffer = new int[Buffsize];      // define stack
            Common.PrintArray(buffer);

            MyQueue myqueue = new MyQueue(buffer);

            int free = Buffsize - head;
            while (free >= 0)
            {
                Console.WriteLine("To add value press :1, to delete value press :2, to exit press: 3 \n");
                int choise = 0;
                Common.ParceD(ref choise);
                switch (choise)
                {
                    case 1:
                        if (free > 0)
                        {
                            Console.WriteLine("Enter what you want to add \n");
                            Common.ParceD(ref put);                        //parce value which needs to be added
                            myqueue.ENQUEUE(put);
                            Common.PrintArray(buffer);
                            free--;
                            Console.WriteLine("free__" + free);         //debug
                            Console.WriteLine("tail__" + tail);         //debug
                        }

                        else if (MyQueue.IsFullQ(free))
                        {
                        }
                        break;

                    case 2:
                        if (free < Buffsize)
                        {

                            Console.WriteLine("deleting # " + tail);
                            myqueue.DEQUEUE();
                            free++;
                            Common.PrintArray(buffer);
                            Console.WriteLine("tail__" + tail);         //debug
                            Console.WriteLine("free__" + free);         //debug
                        }
                        else if (MyQueue.IsEMPTYQ(free, Buffsize))
                        {
                        }
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
