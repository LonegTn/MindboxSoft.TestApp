using Mindbox.FigureArea.Figures;
using Mindbox.FigureArea.Figures.Base;
using NUnit.Framework;
using System;

namespace MindboxSoft.FigureArea.Tests
{
    public class CircleTests
    {
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(10)]
        public void CircleArea(double radius)
        {
            IFigure figure = new Circle(radius);

            double result = figure.Area;
            double expectedResult = Math.PI * Math.Pow(radius, 2);

            Assert.AreEqual(result, expectedResult);
        }
    }
}