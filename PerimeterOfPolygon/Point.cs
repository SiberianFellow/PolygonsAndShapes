using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfPolygon
{
    public class Point
    {
        public readonly double x = 0;
        public readonly double y = 0;
        public readonly string pointName = "Unnamed point";

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            pointName = name;
        }
        public double Distance(Point other)
        {
            return (Math.Sqrt(Math.Pow(x - other.x, 2) + Math.Pow(y - other.y, 2)));
        }
        public string Info()
        {
            return pointName + " X = " + x.ToString() + ", Y = " + y.ToString();
        }
    }
}