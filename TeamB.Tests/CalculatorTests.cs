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
        }
    }
}
