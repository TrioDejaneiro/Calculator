using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestCalculator
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestMethodAdd1()
        {
            // Arrange
            double operand1 = 5;
            double operand2 = 3;
            Addition addition = new Addition(operand1, operand2);

            // Act
            double result = addition.Add();

            // Assert
            Assert.AreEqual(8, result, "5 + 3 should be 8");
        }
        [TestMethod]
        public void TestMethodAdd2()
        {
            // Arrange
            double operand1 = 0.5;
            double operand2 = 1.3;
            Addition addition = new Addition(operand1, operand2);

            // Act
            double result = addition.Add();

            // Assert
            Assert.AreEqual(1.8, result, "0.5 + 1.3 should be 1.8.");
        }
        [TestMethod]
        public void TestMethodAdd3()
        {
            // Arrange
            double operand1 = 0.5;
            double operand2 = 1.33;
            Addition addition = new Addition(operand1, operand2);

            // Act
            double result = addition.Add();

            // Assert
            Assert.AreEqual(1.83, result, "0.5 + 1.33 should be 1.83.");
        }
        [TestMethod]
        public void TestMethodSubstraction1()
        {
            // Arrange
            double operand1 = 10;
            double operand2 = 4;
            Subtraction subtraction = new Subtraction(operand1, operand2);

            // Act
            double result = subtraction.Subtract();

            // Assert
            Assert.AreEqual(6, result, "10 - 4 should be 6");
        }
        [TestMethod]
        public void TestMethodSubstraction2()
        {
            // Arrange
            double operand1 = 10.6;
            double operand2 = 4.6;
            Subtraction subtraction = new Subtraction(operand1, operand2);

            // Act
            double result = subtraction.Subtract();

            // Assert
            Assert.AreEqual(6, result, "10.6 - 4.6 should be 6");
        }
        [TestMethod]
        public void TestMethodSubstraction3()
        {
            // Arrange
            double operand1 = 10.6;
            double operand2 = 4.3;
            Subtraction subtraction = new Subtraction(operand1, operand2);

            // Act
            double result = subtraction.Subtract();

            // Assert
            Assert.AreEqual(6.3, result, "10.6 - 4.3 should be 6.3");
        }
        [TestMethod]
        public void TestMethodSubstraction4()
        {
            // Arrange
            double operand1 = 10.0;
            double operand2 = 4.3;
            Subtraction subtraction = new Subtraction(operand1, operand2);

            // Act
            double result = subtraction.Subtract();

            // Assert
            Assert.AreEqual(5.7, result, "10.0 - 4.3 should be 5.7");
        }
        [TestMethod]
        public void Multiplication1()
        {
            // Arrange
            double operand1 = 7;
            double operand2 = 0;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(0, result, "7 * 0 should be 0");
        }
        [TestMethod]
        public void Multiplication2()
        {
            // Arrange
            double operand1 = 7;
            double operand2 = 1;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(7, result, "7 * 1 should be 7");
        }
        [TestMethod]
        public void Multiplication3()
        {
            // Arrange
            double operand1 = 0;
            double operand2 = 0;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(0, result, "0 * 0 should be 0");
        }
        [TestMethod]
        public void Multiplication4()
        {
            // Arrange
            double operand1 = 1;
            double operand2 = 1;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(1, result, "1 * 1 should be 1");
        }
        [TestMethod]
        public void Multiplication5()
        {
            // Arrange
            double operand1 = 7.0;
            double operand2 = 1.5;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(10.5, result, "7.0 * 1.5 should be 10.5");
        }
        [TestMethod]
        public void Multiplication6()
        {
            // Arrange
            double operand1 = 7;
            double operand2 = 1;
            Multiplication multiplication = new Multiplication(operand1, operand2);

            // Act
            double result = multiplication.Multiply();

            // Assert
            Assert.AreEqual(7, result, "7 * 1 should be 7");
        }
        [TestMethod]
        public void TestMethodDivision1()
        {
            // Arrange
            double operand1 = 10;
            double operand2 = 2;
            Division division = new Division(operand1, operand2);

            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(5, result, "10 divided by 2 should be 5");

        }

        [TestMethod]
        public void TestMethodDivision2()
        {
            // Arrange
            double operand1 = 10;
            double operand2 = 0;
            Division division = new Division(operand1, operand2);
            
            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(-1, result, "10 divided by 0 should be PositiveInfinity");
        }
        [TestMethod]
        public void TestMethodDivision3()
        {
            // Arrange
            double operand1 = 10.5;
            double operand2 = 0;
            Division division = new Division(operand1, operand2);

            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(-1, result, "10.5 divided by 0 should be PositiveInfinity");
        }
        [TestMethod]
        public void TestMethodDivision4()
        {
            // Arrange
            double operand1 = 10.5;
            double operand2 = 0.5;
            Division division = new Division(operand1, operand2);

            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(21, result, "10.5 divided by 0.5 should be 21");
        }
        [TestMethod]
        public void TestMethodDivision5()
        {
            // Arrange
            double operand1 = 10.5;
            double operand2 = 5;
            Division division = new Division(operand1, operand2);

            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(2.1, result, "10.5 divided by 5 should be 2.1");
        }
        [TestMethod]
        public void TestMethodDivision6()
        {
            // Arrange
            double operand1 = 10;
            double operand2 = 5.1;
            Division division = new Division(operand1, operand2);

            // Act
            double result = division.Divide();

            // Assert
            Assert.AreEqual(1.9607843137254903, result, "10 divided by 5.1 should be 1.9607843137254903");
        }
    }
}