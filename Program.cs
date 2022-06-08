using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
   
        static void Main(string[] args)
        {
            // instantiate my object to create a point in memory and hold a ref to it.
            MyObject myObject = new MyObject();

            // a variable to make changing input easy. its better then wrinting Console.Writeline()
            float input = 0;
            Console.WriteLine("Enter health value: ");
            input = float.Parse(Console.ReadLine());
            myObject.HealthAlso = input;
            Console.WriteLine($"Health: {myObject.HealthAlso}");

        }
    }
}
