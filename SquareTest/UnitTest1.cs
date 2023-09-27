using Newtonsoft.Json.Linq;
using SquareLib;

namespace SquareTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleIntSideMaxFirst()
        {
            var a = 5;
            var b = 4;
            var c = 3;
            var p = (a + b + c) / 2;

            Assert.AreEqual(b * c / 2, Square.TriangleArea(a,b,c));
        }
        [TestMethod]
        public void TriangleIntSideMaxAvg()
        {
            var a = 5;
            var b = 13;
            var c = 12;

            Assert.AreEqual(a * c / 2, Square.TriangleArea(a, b, c));
        }
        [TestMethod]
        public void TriangleIntSideMaxLast()
        {
            var a = 6;
            var b = 8;
            var c = 10;

            Assert.AreEqual(a * b / 2, Square.TriangleArea(a, b, c));

        }
        [TestMethod]
        public void TriangleDoubleSide()
        {
            var a = 6.5;
            var b = 8.3; 
            var c = 10.4;
            var p = (a + b + c) / 2;

            Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), Square.TriangleArea(a,b,c));
        }
        [TestMethod]
        public void TriangleNegativeSide()
        {
            var a = -3;
            var b = 8.3; 
            var c = 10.4;

            Assert.AreEqual(0, Square.TriangleArea(a,b,c));
        }
        [TestMethod]
        public void TriangleUnexist()
        {
            var a = 3;
            var b = 1; 
            var c = 10;

            Assert.AreEqual(0, Square.TriangleArea(a,b,c));
        }
        [TestMethod]
        public void CircleIntRadius()
        {
            var radius = 3;

            Assert.AreEqual(Math.PI * radius * radius, Square.CircleArea(radius));
        }
        [TestMethod]
        public void CircleDoubleRadius()
        {
            var radius = 4.5;

            Assert.AreEqual(Math.PI * radius * radius, Square.CircleArea(radius));
        }
        [TestMethod]
        public void CircleNegativeRadius()
        {
            var radius = -5;

            Assert.AreEqual(0, Square.CircleArea(radius));
        }

    }
}