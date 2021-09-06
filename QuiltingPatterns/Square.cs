using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public class Square : Shapes
    {
        public Square(List<decimal> sides, string color)
        {
            this.sides = sides;
            this.color = color;
            this.shape = Shapes.quiltingShape.Triangle;
        }
        public override decimal getArea(List<decimal> sides)
        {
            throw new NotImplementedException();
        }
    }
}
