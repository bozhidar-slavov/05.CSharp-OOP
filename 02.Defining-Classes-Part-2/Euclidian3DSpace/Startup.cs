namespace Euclidian3DSpace
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var point = new Point3D(1, 1, 1);
            var startPoint = Point3D.StartPoint;
            var distance = CalculateDistance.DistanceBetweenTwoPoints(startPoint, point);
            Console.WriteLine("Distance: {0:F2}", distance);

            var path = new Path();
            path.AddPoint(new Point3D(2, 3, 6));
            path.AddPoint(new Point3D(-1, 2, 4));
            path.AddPoint(new Point3D(5, 1, 5));

            PathStorage.SavePath(path);
            Console.WriteLine(PathStorage.LoadPath());
        }
    }
}
