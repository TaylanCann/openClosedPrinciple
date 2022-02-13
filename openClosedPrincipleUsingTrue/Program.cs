using System;

namespace openClosedPrincipleUsingTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public double Area(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
