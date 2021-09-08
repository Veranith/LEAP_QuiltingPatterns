using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public abstract class Shapes
    {   
        public enum quiltingShape { Triangle, Square, Rectangle}
        public quiltingShape shape { get; set; }
        public string color { get; set; }
        public List<decimal> sides { get; set; }

        public abstract decimal getArea(List<decimal>sides);

        public static Shapes createShape(quiltingShape quiltShape)
        {
            switch (quiltShape)
            {
                case quiltingShape.Square:
                    return new square(getShapeSides(1), getShapeColor());

                case quiltingShape.Rectangle:
                    return new rectangle(getShapeSides(2), getShapeColor());

                case quiltingShape.Triangle:
                    return new triangle(getShapeSides(3), getShapeColor());

            }
            return null;
        }

        private static List<decimal> getShapeSides(int numberOfLengths)
        {
            Console.WriteLine($"Enter the length of the sides.");
            var message = new StringBuilder();
            List<decimal> sides = new List<decimal>();

            for (int i = 0; i < numberOfLengths; i++)
            {
                message.Append($"Side {i + 1}:  ");
                sides.Add(userIO.getUserInput(message.ToString()));
                message.Clear();
            }

            return sides;
        }

        private static string getShapeColor()
        {
            var message = new StringBuilder();
            message.Append("Enter the desired color:  ");
            var allowedColors = new List<string> { "red", "black", "white", "rose", "blue", "cyan", "yellow", "pink", "purple", "orange", "banana", "coral", "lime", "green", "gray", "maroon", "brown", "tan" };
            return userIO.getUserInput(message.ToString(), allowedColors);
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{color.Substring(0,1).ToUpper()}{color.Substring(1)} {shape} with an area of {getArea(sides)}.");

            return sb.ToString();
        }
    }
}
