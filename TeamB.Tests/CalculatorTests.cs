using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("98", 98)]
        [TestCase("0", 0)]
        [TestCase("", 0)]
        [TestCase("5 + 4", 9)]
        [TestCase("93 + 1", 94)]
        [TestCase("2 + 2 + 3", 7)]
        [TestCase("93 + -1", 92)]
        [TestCase("5 - 2 - 1", 2)]
        [TestCase("12 - 1", 11)]
        [TestCase("3 * 3", 9)]
        [TestCase("5 * 4", 20)]
        public void ItCalculatesValidProblem(string problem, int answer)
        {
            var calc = new Calculator();
            var result = calc.GetResult(problem);
            Assert.That(result, Is.EqualTo(answer));
        }

        [Test]
        public void ItDoesNotBlowUp()
        {
            var calc = new Calculator();
            Assert.DoesNotThrow(() => calc.GetResult("(1+3) * (7+9)"));
        }
    }
}
