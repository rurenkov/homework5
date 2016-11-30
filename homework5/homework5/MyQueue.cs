using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class MyQueue
    {
        //
        private int[] Array;
        private int head;
        private int tail;
        private int free;


        public MyQueue(int[] array)   // конструктор маЄ бути названий так само як класс. Обовязково!!!
        {
            this.Array = array;
            this.free = 0;
            this.head = 0;
            this.free = Array.Length - head;
        }


        //*******************************************************//
        // enqueue method;
        //*******************************************************//
        public void Enqueue(int put)
        {
            if (free > 0)
            {
                if (head < Array.Length)
                {
                    Array[head] = put;
                    head++;
                }
                else if (head == Array.Length)
                {
                    head = 0;
                    Array[head] = put;
                    head++;
                }
                free--;
                Console.WriteLine("free__" + free);         //debug
                Console.WriteLine("tail__" + tail);         //debug
            }
            else if (MyQueue.IsFull(free))
            {
            }
        }

        //*******************************************************//
        // DEqueue method;
        //*******************************************************//

        public void Dequeue()

        {
            if (free < Array.Length)
            {
                if (tail < Array.Length)
                {
                    Array[tail] = 0;
                    tail++;
                }
                else if (tail == Array.Length)
                {
                    tail = 0;
                    Array[tail] = 0;
                    tail++;
                }
                free++;
                Console.WriteLine("tail__" + tail);         //debug
                Console.WriteLine("free__" + free);         //debug
            }
            else if (MyQueue.IsEmpty(free, Array.Length))
            {
            }
        }

//*******************************************************//
// IS FULLQ method;
//*******************************************************//
public static bool IsFull(int free)
        {

            if (free <= 0)
            {
                Console.WriteLine("QUEUE is full");
            }
            return true;
        }
        //*******************************************************//
        // IS EMPTY method;
        //*******************************************************//
        public static bool IsEmpty(int free, int Buffsize)
        {

            if (free == Buffsize)
            {
                Console.WriteLine("QUEUE is empty");
            }
            return true;
        }

        public static void PrintArray(int[] MYarray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MYarray));

        }



    }
}
