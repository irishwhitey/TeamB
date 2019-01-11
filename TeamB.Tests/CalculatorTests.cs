using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("3 + 4",7)]
        [TestCase("-3 + 4", 1)]
        [TestCase("8 / 4",2)]
        [TestCase("2 * 4", 8)]
        [TestCase("10 - 3",7)]
        [TestCase("3 + 4 + 2",9)]
        [TestCase("10 - 4 - 3",3)]
        public void ItShouldReturnSomething(string problem, decimal expected)
        {
            Assert.That(new Calculator().GetResult(problem), Is.EqualTo(expected));
        }

        [Test]
        public void ItShouldNotBlowUp()
        {
            new Calculator().GetResult("fred + 1");
        }
    }
}
