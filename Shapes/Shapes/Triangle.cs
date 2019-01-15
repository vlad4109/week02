using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape , IFigure
    {
        public Triangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }

        public int Height { get;  }

        public override double CalculateSurface()
        {
            return Width * Height / 2;
        }

        public string Figure()
        {
            return "triangle";
        }

        public override void Print()
        {
            Console.WriteLine($"The area of the {this.Figure()} is: {this.CalculateSurface()}");
        }
    }
}
