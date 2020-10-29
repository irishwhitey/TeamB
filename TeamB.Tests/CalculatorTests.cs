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


        [TestCase("1-2", -1)]
        [TestCase("1-2-3", -4)]
        [TestCase("6 - 2 - 1", 3)]
        public void SimpleSubstractionWorks(string expression, decimal answer)
        {
            var result = _calc.GetResult(expression);
            Assert.AreEqual(answer, result);
        }
    }
}
