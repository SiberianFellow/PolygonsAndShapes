using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfPolygon
{
    public class Polygon
    {
        List<Point> points = new List<Point>();
        public Polygon(Point A, Point B, Point C)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
        }
        public Polygon(Point A, Point B, Point C, Point D)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
        }
        public Polygon(Point A, Point B, Point C, Point D, Point E)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
            points.Add(E);
        }
        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (i < points.Count - 1)
                {
                    perimeter += points[i].Distance(points[i + 1]);
                }
                else
                {
                    perimeter += points[i].Distance(points[0]);
                }
            }
            return perimeter;
        }
        public string Points()
        {
            string result = "";
            foreach (Point point in points)
            {
                result = result + point.Info() + "\n";
            }
            return result;
        }

    }
}