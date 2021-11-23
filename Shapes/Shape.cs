using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        public string shapeName { get; init; }
        public double shapeVolume { get; init; }
        public double volumeLeft { get; internal set; }
        List<Shape> shapesInside = new();
        public Shape()
        {
            shapeName = "Abstract shape";
        }
        public virtual double Volume()
        {
            return 0;
        }
        public bool Add(Shape shape)
        {
            if (volumeLeft >= shape.shapeVolume)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PutInside(Shape shape)
        {
            volumeLeft -= shape.shapeVolume;
            shapesInside.Add(shape);
        }
        public string ShowInfo()
        {
            return shapeName + ", volume = " + shapeVolume.ToString();
        }
        public string ShowShapesInside()
        {
            string result = "";
            foreach (Shape shape in shapesInside)
            {
                result = result + shape.ShowInfo() + "\n";
            }
            return result;
        }
    }
    public class Box : Shape
    {
        public readonly double height;
        public Box(double height) : base()
        {
            this.height = height;
            shapeVolume = Volume();
            volumeLeft = shapeVolume;
            shapeName = "Box";
        }
        public override double Volume()
        {
            return Math.Pow(height, 3);
        }

    }
    public class Cylinder : Shape
    {
        public readonly double radius;
        public readonly double height;
        public Cylinder(double height, double radius) : base()
        {
            this.height = height;
            this.radius = radius;
            shapeVolume = Volume();
            volumeLeft = shapeVolume;
            shapeName = "Cylinder";
        }
        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
    public class Ball : Shape
    {
        public readonly double radius;
        public Ball(double radius) : base()
        {
            this.radius = radius;
            shapeVolume = Volume();
            volumeLeft = shapeVolume;
            shapeName = "Ball";
        }
        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }
    public class Pyramid : Shape
    {
        public readonly double baseArea;
        public readonly double height;
        public Pyramid(double height, double baseArea) : base()
        {
            this.height = height;
            this.baseArea = baseArea;
            shapeVolume = Volume();
            volumeLeft = shapeVolume;
            shapeName = "Pyramid";
        }
        public override double Volume()
        {
            return  baseArea * height / 3;
        }
    }
}
