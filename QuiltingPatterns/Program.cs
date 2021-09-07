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
            while (true)
            {
                switch (userIO.displayMenu())
                {
                    case "t":
                        Console.WriteLine("Creating Triangle.");
                        patterns.Add(Shapes.createShape(Shapes.quiltingShape.Triangle));
                        break;
                    case "s":
                        Console.WriteLine("Creating Square.");
                        patterns.Add(Shapes.createShape(Shapes.quiltingShape.Square));
                        break;
                    case "r":
                        Console.WriteLine("Creating Rectangle.");
                        patterns.Add(Shapes.createShape(Shapes.quiltingShape.Rectangle));
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
}
