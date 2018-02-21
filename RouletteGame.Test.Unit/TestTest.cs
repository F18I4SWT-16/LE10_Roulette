using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute.Core;
using NUnit.Framework;

namespace RouletteGame.Test.Unit
{
    [TestFixture]
    class TestTest
    {
        [Test]
        public void Testies()
        {
            Assert.That(1, Is.EqualTo(1));
        }

        [Test]
        public void TestingTesties()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
