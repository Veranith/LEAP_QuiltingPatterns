using System;
using System.Collections.Generic;
using QuiltingPatterns;

namespace QuiltingPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to RyRob's amazing Quilting Pattern Collector!\n");

            var patterns = new List<Shapes>();

            switch (userIO.displayMenu())
            {
                case "t":
                    Console.WriteLine("create Triangle");
                    break;
                case "s":
                    Console.WriteLine("create square");
                    break;
                case "r":
                    Console.WriteLine("create rectangle");
                    break;
                case "p":
                    userIO.displayPatterns(patterns);
                    break;
                default:
                    return;
            }
        }
    }
}
