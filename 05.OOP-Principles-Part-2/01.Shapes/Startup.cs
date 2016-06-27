namespace Shapes
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Shape[] differentShapes =
            {
                new Rectangle(4.5, 6.5),
                new Rectangle(4, 5.5),
                new Triangle(5.8, 3),
                new Triangle(4.5, 8.5),
                new Square(4)
            };

            foreach (var shape in differentShapes)
            {
                Console.WriteLine("{0} Area --> {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
