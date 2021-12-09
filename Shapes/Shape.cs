using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract string ShapeName { get; }
        public abstract double Volume();
    }
    public class Box : Shape
    {
        public double Height { get; }
        public override string ShapeName { get; }
        public double VolumeLeft {get; internal set;}
        List<Shape> ListOfShapes = new List<Shape>();
        
        public Box(double height)
        {
            this.Height = height;
            VolumeLeft = Volume();
            ShapeName = "Box";
        }
        public override double Volume()
        {
            return Math.Pow(Height, 3);
        }
        public bool Add(Shape shape)
        {   
            double volumeToAdd = shape.Volume();
            if (VolumeLeft >= volumeToAdd)
            {
                VolumeLeft -= volumeToAdd;
                ListOfShapes.Add(shape);
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
            foreach (Shape shape in ListOfShapes)
            {
                result = result + shape.ShapeName + ", Volume = " + shape.Volume() + "\n";
            }
            return result;
        }
    }
    public class Cylinder : Shape
    {
        public double Radius { get; }
        public double Height { get; }
        public override string ShapeName { get; }
        public Cylinder(double height, double radius) : base()
        {
            this.Height = height;
            this.Radius = radius;
            ShapeName = "Cylinder";
        }
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
    public class Ball : Shape
    {
        public double Radius { get; }
        public override string ShapeName { get; }
        public Ball(double radius) : base()
        {
            this.Radius = radius;
            ShapeName = "Ball";
        }
        public override double Volume()
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }
    }
    public class Pyramid : Shape
    {
        public  double BaseArea { get; }
        public double Height { get; }
        public override string ShapeName { get; }
        public Pyramid(double height, double baseArea) : base()
        {
            this.Height = height;
            this.BaseArea = baseArea;
            ShapeName = "Pyramid";
        }
        public override double Volume()
        {
            return BaseArea * Height / 3.0;
        }
    }
}
