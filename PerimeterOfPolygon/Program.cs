using System;
using System.Collections.Generic;
using System.Linq;

namespace PerimeterOfPolygon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Point a = new Point(0, 0);
                Point b = new Point(0, 2);
                Point c = new Point(2, 2);
                Point d = new Point(2, 0);
                Point e = new Point(1, 1);
                Polygon poly = new Polygon(a, b, c, d, e);
                Console.WriteLine("Точки многоугольника: ");
                Console.WriteLine(poly.Points());
                Console.Write("Периметр многоугольника: ");
                Console.WriteLine(poly.Perimeter());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}