using System;
using NUnit.Framework;

namespace Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        //Passing test
        [Test]
        public void Add1and1equals2()
        {
            //Arrange
            var calc = new CalculatorLib.Calculator();
            int expected = 2;

            //Act
            int result = calc.Add(1, 1);

            //Assert
            Assert.AreEqual(result, expected);
        }

        //Failing test
        [Ignore("Intentionally failing")]
        [Test]
        public void Add1and1equals3()
        {
            //Arrange
            var calc = new CalculatorLib.Calculator();
            int expected = 3;

            //Act
            int result = calc.Add(1, 1);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
