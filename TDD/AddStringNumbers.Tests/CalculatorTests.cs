using NUnit.Framework;
using System;

namespace AddStringNumbers.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddOneTwo_ReturnsThree()
        {
            var calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void AddSevenOne_ReturnsEight()
        {
            var calculator = new Calculator();
            int result = calculator.Add(7, 1);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Validate_Name()
        {
            var name = new NameValidator();
            string result = name.Verify("Sajith");
            Assert.AreSame("Sajith", result);
        }
    }
}
