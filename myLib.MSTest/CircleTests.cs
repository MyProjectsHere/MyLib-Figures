using myLib.Basic;

namespace myLib.MSTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetArea_WithValidParameters_ShouldCalculateArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            var Area = circle.GetArea();
            double expected = Math.PI * radius * radius; //вычисления должны быть равны данной формуле расчета площади круга по радиусу
            //double expected = 78.5398; //вычисления должны быть равны S=78.5398, если радиус равен 5;
            Assert.AreEqual(expected, Area);
        }

        [TestMethod]
        public void Radius_WithInvalidParameters_Zero_ShouldThrowException() // задаем не верные параметры радиуса, а имеенно 0;
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0d));
        }

        [TestMethod]
        public void Radius_WithInvalidParameters_Minus_ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-4d)); // задаем не верные параметры радиуса, а имеенно -4;
        }

        [TestMethod]
        public void GetPerimeter_WithValidParameters_ShouldCalculateArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            var Area = circle.GetPerimeter();
            double expected = 2 * Math.PI * radius; //вычисления должны быть равны данной формуле расчета периметра круга по радиусу
            //double expected = 1.4159; // вычисления должны быть равны P=1.4159, если радиус равен 5;
            Assert.AreEqual(expected, Area);
        }
    }
}