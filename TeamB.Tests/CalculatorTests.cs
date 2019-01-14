using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("10 * 4 * 2", 80)]
        [TestCase("80 * 1", 80)]
        public void ItShouldReturnSomething(string problem, decimal expected)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expected));
        }
      
    }
}
