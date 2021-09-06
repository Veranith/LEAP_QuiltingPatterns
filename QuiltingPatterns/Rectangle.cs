using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltingPatterns
{
    public class rectangle : Shapes
    {
        public rectangle(List<decimal> sides, string color)
        {
            this.sides = sides;
            this.color = color;
            this.shape = Shapes.quiltingShape.Rectangle;
        }

        public override decimal getArea(List<decimal> sides)
        {
            return sides[0] * sides[1];
        }
    }
}
