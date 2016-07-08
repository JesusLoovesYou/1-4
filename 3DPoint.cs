namespace _01.Definning_classes
{
    using System;
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D startPointO = new Point3D() { X = 0, Y = 0, Z = 0};
        

        //public Point3D(double x, double y, double z)
        //{
        //    X = x;
        //    Y = y;
        //    Z = z;
        //}

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPointO
        {
            get { return startPointO; }
            
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {

                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D() {X = xyz[0], Y = xyz[1], Z = xyz[2]};
        }
    
    }
}
