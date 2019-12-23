using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ItReturnsASingleNumber()
        {
            var calc = new Calculator();
            var result = calc.GetResult("98");
            Assert.That(result, Is.EqualTo(98));

            var result2 = calc.GetResult("0");
            Assert.That(result2, Is.EqualTo(0));

            var result3 = calc.GetResult(string.Empty);
            Assert.That(result3, Is.EqualTo(0));
        }

        [Test]
        public void ItReturnSumOfFigures()
        {
            var calc = new Calculator();
            var result = calc.GetResult("5 + 4");
            Assert.That(result, Is.EqualTo(9));

            var result2 = calc.GetResult("93 + 1");
            Assert.That(result2, Is.EqualTo(94));
        }
    }
}
