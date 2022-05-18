using Mindbox.FigureArea.Figures.Base;

namespace Mindbox.FigureArea.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _sideOne;
        private readonly double _sideTwo;
        private readonly double _sideThree;

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        public double Area
        {
            get
            {
                double halfPerimeter = (_sideOne + _sideTwo + _sideThree) / 2;
                double halfPerimeterWithoutSideOne = halfPerimeter - _sideOne;
                double halfPerimeterWithoutSideTwo = halfPerimeter - _sideTwo;
                double halfPerimeterWithoutSideThree = halfPerimeter - _sideThree;
                return Math.Sqrt(halfPerimeter * 
                    halfPerimeterWithoutSideOne * 
                        halfPerimeterWithoutSideTwo * 
                            halfPerimeterWithoutSideThree);
            }
        }

        public bool IsRightTriangle
        {
            get
            {
                double[] sides = {_sideOne, _sideTwo, _sideThree};
                double hypotenuse = sides.Max();
                sides = sides.Except(new[] { hypotenuse }).ToArray();
                return Math.Pow(hypotenuse, 2) == sides.Sum(x => Math.Pow(x, 2));
            }
        }

        public double SideOne => _sideOne;

        public double SideTwo => _sideTwo;

        public double SideThree => _sideThree;
    }
}