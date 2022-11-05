using System;

namespace MindboxTest
{
    public class FiguresSquare
    {
        /// <summary>
        /// Summarize the square of circle by radius value
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double Square(float radius)
        {
            return radius * 2 * Math.PI;
        }
        /// <summary>
        /// Summarize the square of triangle by three vertexes
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static double Square(float firstX, float firstY, float secondX, float secondY, float thirdX, float thirdY)
        {
            return Math.Abs(((firstX - thirdX) * (secondY - thirdY) - (secondX - thirdX) * (firstY - thirdY))) / 2;
        }
        /// <summary>
        /// Returns true if triangle has a 90-degrees angle, false in another case
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public static bool isTriangleRight(float firstX, float firstY, float secondX, float secondY, float thirdX, float thirdY)
        {
            double firstSide = Math.Sqrt(Math.Pow(secondX - firstX, 2) + Math.Pow(secondY - firstY, 2));
            double secondSide = Math.Sqrt(Math.Pow(thirdX - firstX, 2) + Math.Pow(thirdY - firstY, 2));
            double thirdSide = Math.Sqrt(Math.Pow(secondX - thirdX, 2) + Math.Pow(secondY - thirdY, 2));
            int maxNum = firstSide > secondSide && firstSide > thirdSide ? 1 : secondSide > firstSide && secondSide > thirdSide ? 2 : thirdSide > firstSide && thirdSide > secondSide ? 3 : -1;
            switch(maxNum)
            {
                case 1:
                    return Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2);
                    break;
                case 2:
                    double expected = Math.Round(Math.Pow(secondSide, 2), 10);
                    double actual = Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2);
                    return expected == actual;
                    break;
                case 3:
                    return Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(firstSide, 2);
                    break;
                default:
                    return false;
            }
        }
        private static bool checkIfRight(double isHigher, double first, double second)
        {
            if (isHigher > first && isHigher > second && Math.Pow(isHigher, 2) == Math.Pow(first, 2) + Math.Pow(second, 2) && first > 0 && second > 0 && isHigher > 0) return true;
            return false;
        }

    }
}
