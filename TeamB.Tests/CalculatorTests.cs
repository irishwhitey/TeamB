﻿using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase("3 + 4",7)]
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
