﻿using NUnit.Framework;

namespace TeamB.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ItShouldReturnSomething()
        {
            var expected = 0;
            Assert.That(new Calculator().GetResult(""), Is.EqualTo(expected));
        }

        [Test]
        public void ItShouldNotBlowUp()
        {
            new Calculator().GetResult("fred + 1");
        }
    }
}
