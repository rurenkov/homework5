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
            BubbleSorter.Print(array1);
            bubbleSorter.Sort();    // визов метода Sort,з класса бабл сортер, передача йому значень масива для сортування.
                                    // він приймає значення, біжить по коду і результат друкуєм в тілі програми.
            BubbleSorter.Print(array1);

            //*******************************************************//
            // INSERTING SORT
            //*******************************************************//

            Console.WriteLine("************************");
            Console.WriteLine("******insert************");
            int[] array2 = new int[] { 9, 6, 3, 1, 4 };

            InsertionSorter insertionSorter = new InsertionSorter(array2);
            InsertionSorter.Print(array2);
            insertionSorter.Sort();
            InsertionSorter.Print(array2);

            //*******************************************************//
            // Stack
            //*******************************************************//

            int add = 0;
            Console.WriteLine("************************");
            Console.WriteLine("******My Stack************");
            int[] array3 = new int[] { 0, 0, 0, 0, 0 };

            MyStack stack = new MyStack(array3);
            MyStack.Print(array3);
            add = 789;                  // debug value
            stack.Push(add);
            MyStack.Print(array3);
            stack.Peek();
            stack.Pop();
            
            //*******************************************************//
            // CIrcular Q
            //*******************************************************//


            int Buffsize = 0;
            int put = 0;
            int free1 = 1;
            int choise = 0;

            Console.WriteLine("Enter the size of an stack");
            Common.ParceD(ref Buffsize);            // parce size of stack
            int[] buffer = new int[Buffsize];      // define stack
            MyQueue.PrintArray(buffer);

            MyQueue myqueue = new MyQueue(buffer);
            
            while (free1 > 0)
            {
                Console.WriteLine("To add value press :1, to delete value press :2, to exit press: 3 \n");

                Common.ParceD(ref choise);
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Enter what you want to add \n");
                        Common.ParceD(ref put);                     //parce value which needs to be added
                        myqueue.Enqueue(put);
                        MyQueue.PrintArray(buffer);
                        break;

                    case 2:
                       
                            myqueue.Dequeue();
                            MyQueue.PrintArray(buffer);
                       
                        break;
                    case 3:

                        {
                            free1 = 0;
                            
                        }
                        break;
                }
            }

            Console.ReadLine();

        }
    }
}
