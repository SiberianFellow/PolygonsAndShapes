using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract string shapeName { get; }
        public abstract double Volume();
    }
    public class Box : Shape
    {
        public double height { get; }
        public override string shapeName { get; }
        public double volumeLeft {get; internal set;}
        List<Shape> shapesInside = new List<Shape>();
        
        public Box(double height)
        {
            this.height = height;
            volumeLeft = Volume();
            shapeName = "Box";
        }
        public override double Volume()
        {
            return Math.Pow(height, 3);
        }
        public bool Add(Shape shape)
        {   
            double volumeToAdd = shape.Volume();
            if (volumeLeft >= volumeToAdd)
            {
                volumeLeft -= volumeToAdd;
                shapesInside.Add(shape);
                return true;
            }
            else
            {
                return false;
            }
        }
        public string ShapesInside()
        {
            string result = "";
            foreach (Shape shape in shapesInside)
            {
                result = result + shape.shapeName + ", Volume = " + shape.Volume() + "\n";
            }
            return result;
        }
    }
    public class Cylinder : Shape
    {
        public double radius { get; }
        public double height { get; }
        public override string shapeName { get; }
        public Cylinder(double height, double radius) : base()
        {
            this.height = height;
            this.radius = radius;
            shapeName = "Cylinder";
        }
        public override double Volume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
    }
    public class Ball : Shape
    {
        public double radius { get; }
        public override string shapeName { get; }
        public Ball(double radius) : base()
        {
            this.radius = radius;
            shapeName = "Ball";
        }
        public override double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
    public class Pyramid : Shape
    {
        public  double baseArea { get; }
        public double height { get; }
        public override string shapeName { get; }
        public Pyramid(double height, double baseArea) : base()
        {
            this.height = height;
            this.baseArea = baseArea;
            shapeName = "Pyramid";
        }
        public override double Volume()
        {
            return  baseArea * height / 3.0;
        }
    }
}
