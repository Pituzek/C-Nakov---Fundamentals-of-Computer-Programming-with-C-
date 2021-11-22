using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20_zad5
{
    class Circle : Shape
    {
        public Circle(double width, double height) : base(width, height)
        {
            if (width != height)
            {
                throw new ArgumentException(
                    "Height is not equal to width in circle shape");
            }

        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.PI * this.Height;
        }

    }
}
