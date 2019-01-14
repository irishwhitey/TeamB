using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("3 + 4", 7)]
        [TestCase("7 * 1", 7)]
        public void ItShouldReturnSomething(string problem, decimal expected)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expected));
        }
      
    }
}
