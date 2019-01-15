using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Shape triangle = new Triangle(6, 5);
            shapes.Add(triangle);

            triangle.Print();

            Shape rectangle = new Rectangle(4, 8);
            shapes.Add(rectangle);

            rectangle.Print();

            Shape square = new Square(4);
            shapes.Add(square);

            square.Print();

        }
    }
}
