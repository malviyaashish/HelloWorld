using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            DateTime dat = DateTime.Now;

            Console.WriteLine("Today is {0:d} at {0:T}.", dat);
            Console.WriteLine("Version: 1.0.0");
            Console.WriteLine("CPP Demo");

            //Console.Write("\nPress any key to continue... ");
            //Console.ReadLine();
        }
    }
}
