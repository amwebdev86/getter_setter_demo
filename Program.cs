using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
   
        static void Main(string[] args)
        {
            // instantiate my object to create a point in memory and hold a ref to it.
            MyObject myObject = new MyObject();

            //set the Health of myObject
            // set the _health private variable
            myObject.Health = 16;

            //Get the Health of my object 
            // references _health private variable 
            Console.WriteLine($"{myObject.Health}");

        }
    }
}
