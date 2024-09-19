using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCalculatorForms
{
    internal class Rectangle
    {
        private double length;
        private double width;

        public void SetLength(double length)
        {
            this.length = length;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
}
