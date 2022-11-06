using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    public class MyStack<T>
    {

        private T[] mynewstack = new T[10];

        private int top = -1;


        public void Push(T value)
        {

            if (isfull())
            {
                Console.WriteLine("the stack is full");
                return;
            }

            top++;
            mynewstack[top] = value;

        }

        public void Pop()
        {

            if (isempty())
            {
                Console.WriteLine("the stack is empty");
                return;
            }



            top--;
            return;

        }


        public bool isempty()
        {
            if (top < 0)
            {

                return true;
            }
            return false;
        }

        public bool isfull()
        {
            if (top < 10)
                return false;
            return true;
        }

        public void Print()
        {


            if (isempty())
            {
                Console.WriteLine("the stack is empty");
                return;
            }

            for (int i = top; i > -1; i--)
            {

                Console.WriteLine(mynewstack[i]);
                Console.WriteLine("\n");
            }
        }
    }
}
