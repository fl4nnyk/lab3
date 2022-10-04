using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointandFigure
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
    public class Figure
    {
        private Point[] points;
        private string name;

        public Figure(Point[] points)
        {
            if (points.Length < 3 && points.Length > 5)
            {
                throw new ArgumentException("Out of range");
            }
            name = Enum.GetName(typeof(Polygon), points.Length);
            this.points = points;
        }

        public float LengthSide(Point A, Point B)
        {
            return MathF.Sqrt(MathF.Pow(B.X - A.X, 2) + MathF.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            float perimetr = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }
            perimetr += LengthSide(points[points.Length - 1], points[0]);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Perimetr: {perimetr}");
        }
    }
    public enum Polygon
    {
        Triangle = 3,
        Quadrilateral = 4,
        Pentagon = 5
    }
    public class Program3
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
                new Point(2, 1, "A"),
                new Point(5, 5, "B"),
                new Point(-4, 3, "C"),
                new Point(6, -3, "D"),
            };

            Figure figure = new Figure(points);
            figure.PerimeterCalculator();
        }
    }
}
