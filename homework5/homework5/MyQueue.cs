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

        public MyQueue(int[] array)   // конструктор маЄ бути названий так само як класс. Обовязково!!!
        {
            this.Array = array;

        }


        //*******************************************************//
        // enqueue method;
        //*******************************************************//
        //   public void ENQUEUE(ref int put, ref int Buffsize, ref int head, ref int[] buffer)
        public void Enqueue(int put)
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
        }

        //*******************************************************//
        // DEqueue method;
        //*******************************************************//

        public void Dequeue()

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




    }
}
