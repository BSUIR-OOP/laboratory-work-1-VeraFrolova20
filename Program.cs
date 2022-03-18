using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<BaseFigure>()
            {
            new section(0,0,4,3),
            new Triangle(5, 5, 20),

            new Quadrangle(10,10, 20,20, 30,30, 40,40),
            new Parallelogram(10,10, 20,40, 40,40, 30,10),
            new Rectangle(0,2, 4,2, 4,0, 0,0),
            new Square(0,2, 2,2, 2,0, 0,0),

            new Ellipse(0, 0, 20, 40),
            new Circle(0, 0, 5),
            };
        
            foreach(var f in figures)
            {
                f.PrintFigure();
            }
        
            Console.ReadKey();
        }
    }
}
