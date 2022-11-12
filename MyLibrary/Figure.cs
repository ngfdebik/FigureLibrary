using System;

namespace MyLibrary
{
    public class Figure
    {
        public const double pi = 3.14;
        public double AreaFigure(double radius)
        {
            return pi * Math.Pow(radius, 2);
        }
        public double AreaFigure(double A, double B, double C)
        {
            double p = (A + B + C)/2;
            double expression = p * (p - A) * (p - B) * (p - C);
            if (expression > 0)
                return Math.Sqrt(expression);
            else
                return 0;
        }
    }

    public class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double AreaCircle()
        {
            return  new Figure().AreaFigure(radius);
        }
    }

    public class Triangle : Figure
    {
        private double[] Sides = new double[3];
        private bool isRectangular;

        private double[] SortInput(double A, double B, double C)
        {
            double[] arr = new double[3];
            arr[0] = Math.Max(Math.Max(A, B), C);
            arr[2] = Math.Min(Math.Min(A, B), C);
            arr[1] = (A + B + C) - arr[0] - arr[2];
            return arr;
        }
        public Triangle(double A, double B, double C)
        {
            Sides = SortInput(A, B, C);
            isRectangular = (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2));
        }
        public double AreaTriangle()
        {
            if (isRectangular)
                return Sides[0] * Sides[1] / 2;
            else 
                return new Figure().AreaFigure(Sides[0], Sides[1], Sides[2]);
        }
    }
}
