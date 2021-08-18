using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello People!");
            int a = 10;
            int b = 11;
            int max = a == b ? a : b;
            Console.WriteLine("In {0} and {1}: {2} is Higest Number", a,b,max);
            int c = 12;
            string result = c%2 == 0 ? "Even Number" : "Odd Number";
            Console.WriteLine("{0} is {1}", c,result);
        }
    }
}
