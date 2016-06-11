namespace Euclidian3DSpace
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            var writer = new StreamWriter(@"..\..\points.txt", false);

            using (writer)
            {
                foreach (var item in path.SequenceOfPoints)
                {
                    writer.WriteLine("{0, 3}, {1, 3}, {2, 3}", item.X, item.Y, item.Z);
                }
            }
        }

        public static Path LoadPath()
        {
            var reader = new StreamReader(@"..\..\points.txt");
            var path = new Path();

            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    double[] coordinates = currentLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
                    path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    currentLine = reader.ReadLine();
                }
            }

            return path;
        }
    }
}
