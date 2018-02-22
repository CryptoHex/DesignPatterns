using System;
using System.Diagnostics;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slowly creating new prototype object...");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            NumberDatabase numberDatabase = new NumberDatabase();
            numberDatabase.GenerateRandomNumbers();
            Console.WriteLine(sw.Elapsed.ToString());
            sw.Reset();

            Console.WriteLine("---");

            Console.WriteLine("Quickly copying prototype object...");
            sw.Start();
            NumberDatabase newNumberDatabase = (NumberDatabase) numberDatabase.Clone();
            Console.WriteLine(sw.Elapsed.ToString());


        }
    }
}
