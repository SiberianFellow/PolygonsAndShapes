using Xunit;

namespace PerimeterOfPolygon.Tests
{
    public class UnitTestPerimeterOfPolygon
    {
        [Fact]
        public void PerimeterTest()
        {
            Polygon polygon = new Polygon(new Point(0, 0), new Point(0, 1), new Point(1, 0));
            double result = polygon.Perimeter();
            Assert.Equal(3.41, result, 2);
        }
        [Theory]
        [InlineData("Test point", 1, 1)]
        public void TestPointInfo(string pointName, double x, double y)
        {
            Point point = new Point(x, y, pointName);
            Assert.Equal("Test point X = 1, Y = 1", point.Info());
        }
    }
}