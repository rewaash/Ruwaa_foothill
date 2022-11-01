
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace ConsoleApp1
{




    using System;



    public class myobj {

        public int Id { set; get; }
        public string Name { set; get; }
        public double avg { set; get; }




        public override string ToString()
        {
            return "Id : "+ this.Id + ", Name " + this.Name + ", Avg"+this.avg;
        }

    }

    // We use < > to specify Parameter type
    public class mystack<T>
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

            for (int i = top; i >-1 ; i--)
            {

                Console.WriteLine(mynewstack[i]);
                Console.WriteLine("\n");
            }
        }
    }
        // Driver class
        class Test
        {

            // Main method
            static void Main(string[] args)
            {
                mystack<int> ss = new mystack<int>();
                ss.Push(25);
                ss.Push(100);
                ss.Push(1472);
                ss.Push(0);
            ss.Push(5);
            ss.Push(3);
                ss.Pop();
                ss.Print();
            Console.WriteLine("**********************************************************");

            Console.WriteLine();

            mystack<string> s2 = new mystack<string>();
            s2.Push("Ruwaa");
            s2.Push("Shehadeh");
            s2.Push("Ahmad");
            s2.Push("Shehadeh");
            s2.Push("Alawneh");
           
            s2.Pop();
            s2.Print();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();


            mystack<double> s3 = new mystack<double>();
            s3.Push(0.025);
            s3.Push(10.357);
            s3.Push(15.2);
            s3.Push(147.58);
            s3.Push(18.0);

            s3.Pop();
            s3.Print();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();





          


            mystack<myobj> s4 = new mystack<myobj>();
            myobj ob1=new myobj();
            ob1.avg = 122.58;
            ob1.Name = "Rewaa";
            ob1.Id = 111;

            myobj ob2=new myobj();
            ob2.avg = 147.12;
            ob2.Name = "Raghad";
            ob2.Id = 222;

            myobj ob3=new myobj();

            ob3.avg = 51.17;
            ob3.Name = "Masa";
            ob3.Id = 333;

            myobj ob4 = new myobj();

            ob4.avg = 99.9;
            ob4.Name = "Lamar";
            ob4.Id = 444;


            myobj ob5 = new myobj();

            ob5.avg = 63.12;
            ob5.Name = "Yaman";
            ob5.Id = 555;
            s4.Push(ob1);
            s4.Push(ob2);
            s4.Push(ob3);
                
            s4.Push(ob4);
            s4.Push(ob5);

            s4.Pop();
                s4.Print();


       
            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            int x = Console.Read();
            }
        }

    
}