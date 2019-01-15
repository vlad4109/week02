using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape , IFigure
    {
        public Square(int width)
        {
            Width = width;
        }

        public int Width { get; set; }

        public override double CalculateSurface()
        {
            return Width * Width;
        }

        public string Figure()
        {
            return "square";
        }

        public override void Print()
        {
            Console.WriteLine($"The area of the {this.Figure()} is: {this.CalculateSurface()}");
        }
    }
}
