using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public class square : Shapes
    {
        public square(List<decimal> sides, string color)
        {
            this.sides = sides;
            this.color = color;
            this.shape = Shapes.quiltingShape.Square;
        }
        public override decimal getArea(List<decimal> sides)
        {
            return sides[0] * sides[0];
        }
    }
}
