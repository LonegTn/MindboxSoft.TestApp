using Mindbox.FigureArea.Figures.Base;

namespace Mindbox.FigureArea.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area => Math.PI * Math.Pow(_radius, 2);

        public double Radius => _radius;
    }
}