namespace _01.Definning_classes
{
    using System.Collections.Generic;

    public class Path
    {
        public Path()
        {
            this.PointsColection = new List<Point3D>();
        }

        public List<Point3D> PointsColection { get; set; }

        public void AddPoint(Point3D point)
        {
            this.PointsColection.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.PointsColection.Remove(point);
        }


    }
}
