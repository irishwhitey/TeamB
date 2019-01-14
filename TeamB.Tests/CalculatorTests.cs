using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("3 + 4", 7)]
        [TestCase("-3 + 4", 1)]
        [TestCase("8 / 4", 2)]
        [TestCase("2 * 4", 8)]
        [TestCase("10 - 3", 7)]
        [TestCase("3 + 4 + 2", 9)]
        [TestCase("10 - 4 - 3", 3)]
        [TestCase("9 + 2 + 1", 12)]        
        [TestCase("10 * 4 * 2", 80)]        
        [TestCase("24 / 6 / 2", 2)]        
        [TestCase("10 ^ 2", 100)]        
        [TestCase("10 + -4", 6)]        
        [TestCase("3 * 1 * -4", -12)]        
        public void ItShouldReturnSomething(string problem, decimal expected)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expected));
        }
      
        [TestCase("3 + 4", 7)]
        public void ItShouldReturnSomething_ProperVersion(string problem, decimal expected)
        {
            var result = 3M + 4;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
