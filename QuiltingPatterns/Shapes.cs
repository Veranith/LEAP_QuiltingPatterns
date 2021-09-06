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
        //public abstract void createShape();
        
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Your shape is a {color} {shape}, and the area is {getArea(sides)}.");

            return sb.ToString();
        }
    }
}
