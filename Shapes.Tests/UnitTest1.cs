using Xunit;
using System.Collections.Generic;

namespace Shapes.Tests
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new Box(10);
            double volume = box.Volume();
            Assert.Equal(1000.0, volume, 3);
        }
        [Fact]
        public void BoxAddingShapesTest()
        {
            Box box = new Box(10);
            List<Shape> list = new();
            list.Add(new Pyramid(1, 1));
            list.Add(new Ball(10));
            bool result = true; 
            foreach (Shape shape in list)
            {
                result = box.Add(shape);
            }
            Assert.False(result);
        }
        [Fact]
        public void BoxContaintmentTest()
        {
            Box box = new Box(10);
            List<Shape> list = new();
            list.Add(new Pyramid(1, 1));
            list.Add(new Ball(1));
            list.Add(new Cylinder(2, 2));
            string result = "";
            foreach (Shape shape in list)
            {
                box.Add(shape);
                result = result + shape.shapeName + ", Volume = " + shape.Volume() + "\n";
            }
            Assert.Equal(result, box.ShapesInside());
        }
        [Fact]
        public void BallVolumeTest()
        {
            Ball ball = new Ball(10);
            double volume = ball.Volume();
            Assert.Equal(4188.79, volume, 3);
        }
        [Fact]
        public void PyramidVolumeTest()
        {
            Pyramid pyramid = new Pyramid(1, 1);
            double volume = pyramid.Volume();
            Assert.Equal(0.333, volume, 3);
        }
        [Fact]
        public void CylinderTest()
        {
            Cylinder cylinder = new Cylinder(10, 1);
            double volume = cylinder.Volume();
            Assert.Equal(31.416, volume, 3);
        }
    }
}