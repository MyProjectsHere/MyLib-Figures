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
            double expected = Math.PI * radius * radius; //���������� ������ ���� ����� ������ ������� ������� ������� ����� �� �������
            //double expected = 78.5398; //���������� ������ ���� ����� S=78.5398, ���� ������ ����� 5;
            Assert.AreEqual(expected, Area);
        }

        [TestMethod]
        public void Radius_WithInvalidParameters_Zero_ShouldThrowException() // ������ �� ������ ��������� �������, � ������� 0;
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0d));
        }

        [TestMethod]
        public void Radius_WithInvalidParameters_Minus_ShouldThrowException()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-4d)); // ������ �� ������ ��������� �������, � ������� -4;
        }

        [TestMethod]
        public void GetPerimeter_WithValidParameters_ShouldCalculateArea()
        {
            double radius = 5;
            var circle = new Circle(radius);
            var Area = circle.GetPerimeter();
            double expected = 2 * Math.PI * radius; //���������� ������ ���� ����� ������ ������� ������� ��������� ����� �� �������
            //double expected = 1.4159; // ���������� ������ ���� ����� P=1.4159, ���� ������ ����� 5;
            Assert.AreEqual(expected, Area);
        }
    }
}