using System;

namespace Homework8_ConsoleApp.Task3
{
    class Circle : IFigure
    {
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        private Point Center;
        private double Radius;
        public string GetInfo()
        {
            return $"Radius={Radius}, S={GetSquare()}, Length={GetLength()}";
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
