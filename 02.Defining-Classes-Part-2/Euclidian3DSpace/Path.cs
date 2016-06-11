namespace Euclidian3DSpace
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        public Path()
        {
            this.SequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints { get; set; }

        public void AddPoint(Point3D point)
        {
            this.SequenceOfPoints.Add(point);
        }
        
        public override string ToString()
        {
            var output = new StringBuilder();
            foreach (var item in SequenceOfPoints)
            {
                output.AppendFormat("X = {0, 2}, Y = {1, 2}, Z = {2, 2}\n", item.X, item.Y, item.Z);
            }
            
            return output.ToString().TrimEnd('\n'); 
        }
    }
}
