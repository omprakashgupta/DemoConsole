using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Solid.OpenClose
{
    internal class OpenClosePrinciple
    {
        public void Run()
        {
            IShape[] shape = new IShape[2];

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 1;
            rectangle.Height = 1;

            Circle circle = new Circle();
            circle.Radius = 1;

            shape[0] = rectangle;
            shape[1] = circle;

            AreaCalculator areaCalculator = new AreaCalculator();
            double area = areaCalculator.Area(shape);
            Console.WriteLine(area);

        }
    }
}
