using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void BasicMultiplyTest()
        {
            decimal result = new Calculator().GetResult("3 * 2");
            Assert.That(6, Is.EqualTo(result));
        }
    }
}
