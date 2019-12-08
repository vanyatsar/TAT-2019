using System;

namespace CW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[][] points = new Point[2][];
            Triangle[] triangles = new Triangle[2];

            for (int i = 0; i < 2; i++)
            {
                points[i] = new Point[3];
                for (int j = 0; j < 3; j++)
                {
                    points[i][j] = new Point(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                }
                triangles[i] = new Triangle(points[i]);
            }

            for (int i = 0; i < triangles.Length; i++)
            {
                Console.WriteLine(triangles[i].ToString());
            }

            Console.WriteLine(triangles[0].Equals(triangles[1]));
        }
    }
}
