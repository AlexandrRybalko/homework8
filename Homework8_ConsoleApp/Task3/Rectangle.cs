namespace Homework8_ConsoleApp.Task3
{
    public class Rectangle : IFigure
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        private double Width;
        private double Height;

        public string GetInfo()
        {
            return $"Perimeter={GetPerimeter()}, S={GetSquare()}";
        }
        public double GetSquare()
        {
            return Width * Height;
        }
        public double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
    }
}
