using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Calculator();
        }

        [TestCase("1+2", 3 )]
        [TestCase("1+2+3", 6)]
        [TestCase("1 + 2 + 3", 6)]
        public void SimpleAdditionWorks(string expression, decimal answer)
        {
            var result = _calc.GetResult(expression);
            Assert.AreEqual(answer, result);
        }
    }
}
