using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
   
        static void Main(string[] args)
        {
            // instantiate my object to create a point in memory and hold a ref to it.
            MyObject myObject = new MyObject();
            myObject.Health = 16;
            Console.WriteLine($"{myObject.Health}");

        }
    }
}
