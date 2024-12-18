using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Assignment16.Program.Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Assignment16.Program.Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            int result = calculator.Add(5, 3);
            Assert.AreEqual(8, result, "Add method failed.");
        }

        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result, "Subtract method failed.");
        }

        [Test]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int result = calculator.Multiply(5, 3);
            Assert.AreEqual(15, result, "Multiply method failed.");
        }

        [Test]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result, "Divide method failed.");
        }

        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }
    }
}
