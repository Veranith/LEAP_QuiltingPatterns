using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public class triangle : Shapes
    {
        public triangle(List<decimal> sides, string color)
        {
            this.sides = sides;
            this.color = color;
            this.shape = Shapes.quiltingShape.Triangle;
        }

        public override decimal getArea(List<decimal> sides)
        {
            decimal a = sides[0];
            decimal b = sides[1];
            decimal c = sides[2];
            decimal s = (a + b + c) / 2;

            return Math.Round((decimal)Math.Sqrt((double)(s * (s - a) * (s - b) * (s - c))), 3);
        }
    }
}
