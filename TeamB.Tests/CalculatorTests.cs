using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("2 * 8",7)]
        public void ItShouldReturnSomething(string problem, decimal expected)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expected));
        }
      
    }
}
