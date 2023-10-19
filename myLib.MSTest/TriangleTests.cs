using myLib.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLib.MSTest
{
    [TestClass]
    public class CTriangleTests
    {
        [TestMethod]
        public void TypeTriangle_Rectangular_WithValidParameters_ShouldCalculateArea() // Тип треугольника (прямогульный)
        {
            double A = 5;
            double B = 12;
            double C = 13;
            var triangle = new Triangle(A, B, C);
            var result = triangle.GetTypeTriangle();
            string expected = "Треугольник прямоугольный";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TypeTriangle_IsNotRectangular_WithValidParameters_ShouldCalculateArea() // Тип треугольника (не прямогульный)
        {
            double A = 5;
            double B = 12;
            double C = 14;
            var triangle = new Triangle(A, B, C);
            var result = triangle.GetTypeTriangle();
            string expected = "Треугольник не прямоугольный";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetPerimeter_WithValidParameters_ShouldCalculatePerimeter()
        {
            double A = 9;
            double B = 8;
            double C = 6;
            var triangle = new Triangle(A, B, C);
            var result = triangle.GetPerimeter();
            double expected = 23;
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void GetArea_WithValidParameters_ShouldCalculateArea()
        {
            double A = 5;
            double B = 5;
            double C = 5;
            var triangle = new Triangle(A,B,C);
            var result = triangle.GetArea();
            double expected = 10.825317547305483;
            Assert.AreEqual(expected, result);
        }



        [TestMethod]
        public void Sides_Triangle_WithInvalidParameters_Zero_ShouldThrowException() // задаем не верные параметры одной из сторон(нулевое значение);
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0,1,1));
        }

        [TestMethod]
        public void Sides_Triangle_WithInvalidParameters_Minus_ShouldThrowException() // задаем не верные параметры одной из сторон(минусовое значение);
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 1));
        }

        [TestMethod]
        public void TheTriangleDoesNotExist_WithInvalidParameters_SideA_ShouldThrowException() // задаем не верные параметры одной из сторон(Треугольник не существует (Сторона А больше суммы других сторон));
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 1, 1));
        }

        [TestMethod]
        public void TheTriangleDoesNotExist_WithInvalidParameters_SideB_ShouldThrowException() // задаем не верные параметры одной из сторон(Треугольник не существует (Сторона B больше суммы других сторон));
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 3, 1));
        }

        [TestMethod]
        public void TheTriangleDoesNotExist_WithInvalidParameters_SideC_ShouldThrowException() // задаем не верные параметры одной из сторон(Треугольник не существует (Сторона C больше суммы других сторон));
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, 3));
        }
    }
}
