namespace _01.Definning_classes
{
    using System;
    public static class TwoPointDistance
    {
        /// <summary>
        /// d=(x1−x0)2+(y1−y0)2+(z1−z0)2
        /// </summary>
        /// <param name="firstPoint"></param>
        /// <param name="secondPoint"></param>
        /// <returns>DistanceBetwienTwoPoints</returns>
        public static double CalcTwoPointDistance(Point3D firstPoint, Point3D secondPoint)
        {
            return  Math.Sqrt(
                (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)+
                (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));
        }

        public static Point3D ParsePoint(this Point3D point, string text)
        {
            var newPoint = new Point3D();



            return newPoint;
        }

    }
}
