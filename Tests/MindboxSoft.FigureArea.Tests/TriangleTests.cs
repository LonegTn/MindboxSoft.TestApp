using Mindbox.FigureArea.Figures;
using Mindbox.FigureArea.Figures.Base;
using NUnit.Framework;

namespace MindboxSoft.FigureArea.Tests
{
    public class TriangleTests
    {
        [TestCase(3, 4, 5, 6)]
        [TestCase(6, 8, 10, 24)]
        public void TriangleArea(double sideOne, double sideTwo,
            double sideThree, double expectedResult)
        {
            IFigure figure = new Triangle(sideOne, sideTwo, sideThree);

            double result = figure.Area;

            Assert.AreEqual(result, expectedResult);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(6, 8, 10, true)]
        [TestCase(3, 4, 6, false)]
        public void TriangleIsRight(double sideOne, double sideTwo,
            double sideThree, bool expectedResult)
        {
            Triangle triangle = new Triangle(sideOne, sideTwo, sideThree);

            bool result = triangle.IsRightTriangle;

            Assert.AreEqual(result, expectedResult);
        }
    }
}
