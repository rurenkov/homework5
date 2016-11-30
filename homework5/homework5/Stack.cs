using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class MyStack
    {

        private int[] Array;
        private int top;
     //   private int tail;
       // private int free;


        public MyStack(int[] array)   // конструктор маЄ бути названий так само як класс. Обовязково!!!
        {
            this.Array = array;
            this.top = 0;
      //      this.free = Array.Length - head;
        }


        //*******************************************************//
        // push method;
        //*******************************************************//
        public  void Push(int add)
        {

            if (top != Array.Length)
            {
                Array[top] = add;
                top++;
            }
             Console.WriteLine("top_push_" + top);         //debug
          
        }

        //*******************************************************//
        // EMPTY stack;
        //*******************************************************//

        public bool IsEmpty()
        {

            if (top == 0)
            {
                Console.WriteLine("stack is empty");

            }
            return true;
        }
        //*******************************************************//
        // is FULL  stack;
        //*******************************************************//

        public bool IsFull()
        {

            if (top > Array.Length)
            {
                Console.WriteLine("Stack is full");
            }
            return true;
        }

        //*******************************************************//
        // pop method;
        //*******************************************************//
        public void Pop()
        {

            if (top > 0)
            {
                Array[top - 1] = 0;
                top--;
            }
            Console.WriteLine("top_pop_" + top);         //debug
          
        }
        //*******************************************************//
        // peek method;
        //*******************************************************//
        //need to fix
        public void Peek()
        {

            if (top > 0)
            {
                Array[top] = top;
            }

            Console.WriteLine("top_peek_" + top);  //debug

        }

        public static void Print(int[] MyArray)
        {

            Console.WriteLine("[{0}]", string.Join(", ", MyArray));

        }

    }
}
