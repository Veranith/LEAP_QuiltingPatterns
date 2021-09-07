using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public static class userIO
    {
        public static string getUserInput(string message, List<string> validStrings)
        {
            string userInput;
            do
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }
            while (!validStrings.Contains(userInput.ToLower()));

            return userInput.ToLower();
        }

        public static decimal getUserInput(string message)
        {
            string userInput;
            decimal result;
            do
            {
                Console.WriteLine(message);
                userInput = Console.ReadLine();
            }
            while (!decimal.TryParse(userInput, out result));

            return result;
        }

         public static void displayPatterns(List<Shapes> patterns)
        {
            if (patterns.Count > 0)
            {
                for (int i = 0; i < patterns.Count; i++)
                {
                    Console.Write($"Pattern {i + 1}:  {patterns[i].ToString()}");
                }
            } else
            {
                Console.WriteLine("No patterns stored yet.");
            }
            Console.WriteLine();
        }

        public static string displayMenu()
        {
            // Get input from user, new shape or print.
            var message = new StringBuilder();

            message.AppendLine("T) Add a triangle");
            message.AppendLine("S) Add a square");
            message.AppendLine("R) Add a rectangle");
            message.AppendLine("P) Print shapes");
            message.Append("\nSelect an option: ");

            var vaildStrings = new List<string> { "t", "s", "r", "p" };

            return getUserInput(message.ToString(), vaildStrings);
        }
    }
}
