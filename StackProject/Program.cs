using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyStack<int> StackOfInt = new MyStack<int>();
            StackOfInt.Push(25);
            StackOfInt.Push(100);
            StackOfInt.Push(1472);
            StackOfInt.Push(0);
            StackOfInt.Push(5);
            StackOfInt.Push(3);
            StackOfInt.Pop();
            StackOfInt.Print();
            Console.WriteLine("**********************************************************");

            Console.WriteLine();

            MyStack<string> StackOfString = new MyStack<string>();
            StackOfString.Push("Ruwaa");
            StackOfString.Push("Shehadeh");
            StackOfString.Push("Ahmad");
            StackOfString.Push("Shehadeh");
            StackOfString.Push("Alawneh");

            StackOfString.Pop();
            StackOfString.Print();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();


            MyStack<double> StackOfDouble = new MyStack<double>();
            StackOfDouble.Push(0.025);
            StackOfDouble.Push(10.357);
            StackOfDouble.Push(15.2);
            StackOfDouble.Push(147.58);
            StackOfDouble.Push(18.0);

            StackOfDouble.Pop();
            StackOfDouble.Print();
            Console.WriteLine("**********************************************************");
            Console.WriteLine();








            MyStack<MyObject> StackOfObject = new MyStack<MyObject>();
            MyObject myobject = new MyObject();
            myobject.avg = 122.58;
            myobject.Name = "Rewaa";
            myobject.Id = 111;

            MyObject myobject2 = new MyObject();
            myobject2.avg = 147.12;
            myobject2.Name = "Raghad";
            myobject2.Id = 222;

            MyObject myobject3 = new MyObject();

            myobject3.avg = 51.17;
            myobject3.Name = "Masa";
            myobject3.Id = 333;

            MyObject myobject4 = new MyObject();

            myobject4.avg = 99.9;
            myobject4.Name = "Lamar";
            myobject4.Id = 444;


            MyObject myobject5 = new MyObject();

            myobject5.avg = 63.12;
            myobject5.Name = "Yaman";
            myobject5.Id = 555;
            StackOfObject.Push(myobject);
            StackOfObject.Push(myobject2);
            StackOfObject.Push(myobject3);

            StackOfObject.Push(myobject4);
            StackOfObject.Push(myobject5);

            StackOfObject.Pop();
            StackOfObject.Print();



            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            int x = Console.Read();
 

        }
    }
}
