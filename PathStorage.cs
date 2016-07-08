namespace _01.Definning_classes
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string pathIdentifier) //saves the file in the main project directory
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {

                for (int i = 0; i < path.PointsColection.Count; i++)
                {
                    sw.WriteLine(path.PointsColection[i]);
                }

            }
        }

        public static Path LoadPath(string filePath)
        {
            var path = new Path();
            var sr = new StreamReader(filePath);

            using (sr)
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
            
        }
    }
}
