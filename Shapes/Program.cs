using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                double basicBoxSize = 10;
                double k = basicBoxSize * 0.5; // коэффициент размеров для создаваемых рандомно фигур
                Console.WriteLine("Будем складывать в такую коробку:");
                Box boxToPutIn = new(basicBoxSize);
                Console.WriteLine(boxToPutIn.ShapesInside());
                Random rnd = new Random();
                bool enoughVolume = true;
                while (enoughVolume)
                {
                    int randomInt = rnd.Next(4);
                    switch (randomInt)
                    {
                        case 0:
                            {
                                Box randomBox = new(k * rnd.NextDouble());
                                if (!boxToPutIn.Add(randomBox))
                                {
                                    enoughVolume = false;
                                }
                                break;
                            }
                        case 1:
                            {
                                Ball randomBall = new(k * rnd.NextDouble());
                                if (!boxToPutIn.Add(randomBall))
                                { 
                                    enoughVolume = false;
                                }
                                break;
                            }
                        case 2:
                            {
                                Pyramid randomPyramid = new(k * rnd.NextDouble(), k * rnd.NextDouble());
                                if (!boxToPutIn.Add(randomPyramid))
                                {
                                    enoughVolume = false;
                                }
                                break;
                            }
                        default:
                            {
                                Cylinder randomCylinder = new(k * rnd.NextDouble(), k * rnd.NextDouble());
                                if (!boxToPutIn.Add(randomCylinder))
                                {
                                    enoughVolume = false;
                                }
                                break;
                            }
                    }
                }
                Console.WriteLine($"There is not enough space for the next shape, volume left: {boxToPutIn.volumeLeft}");
                Console.WriteLine("There are next shapes inside: ");
                Console.WriteLine(boxToPutIn.ShapesInside());
                Console.ReadLine();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
}