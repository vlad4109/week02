using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape , IFigure
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public override double CalculateSurface()
        {
            return Width * Height;
        }

        public string Figure()
        {
            return "rectangle";
        }

        public override void Print()
        {
            Console.WriteLine($"The area of the {Figure()} is: {this.CalculateSurface()}");
        }
    }
}
