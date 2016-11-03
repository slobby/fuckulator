using System;
using NUnit.Framework;
using Fuckulator;

namespace UnitTestFuckulator
{
    [TestFixture]
    public class UnitTestFuckulator
    {
        [Test]

        public void SumOfTwoNumbers()

        {

            Assert.AreEqual(Fuckulator.Fuckulator.Add(5,5), 10);

        }
    }
}
