using MindboxTest;
using System.Windows;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(0, 0, 0, 2, 2, 2, ExpectedResult = true)]
        [TestCase(3, 1, 2, 2, 2, 3, ExpectedResult = false)]
        [TestCase(0, 0, 0, 0, 0, 0, ExpectedResult = false)]
        public bool Test1(float firstX, float firstY, float secondX, float secondY, float thirdX, float thirdY)
        {
            return FiguresSquare.isTriangleRight(firstX, firstY, secondX, secondY, thirdX, thirdY);
        }
        [TestCase(0, 0, 0, 2, 2, 2, 2f)]
        [TestCase(0, 0, 0, 0, 0, 0, 0)]
        public void Test2(float firstX, float firstY, float secondX, float secondY, float thirdX, float thirdY, float result)
        {
            double res = FiguresSquare.Square(firstX, firstY, secondX, secondY, thirdX, thirdY);
            Assert.AreEqual(result, res);
        }
        [TestCase(0, 0)]
        public void Test3(double rad, float res)
        {
            Assert.AreEqual(res, FiguresSquare.Square((float)rad));
        }
    }
}