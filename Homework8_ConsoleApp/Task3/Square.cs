namespace Homework8_ConsoleApp.Task3
{
    public class Square : IFigure
    {
        private double Length;

        public string GetInfo()
        {
            return $"Perimeter={GetPerimeter()}, S={GetSquare()}";
        }

        public double GetSquare()
        {
            return Length * Length;
        }
        public double GetPerimeter()
        {
            return Length * 4;
        }
    }
}
