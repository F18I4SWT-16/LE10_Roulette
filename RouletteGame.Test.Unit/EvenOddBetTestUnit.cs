using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Test.Unit
{
    [TestFixture]
    class EvenOddBetTestUnit
    {
        private Bet _uut;
        private IField _field;

        [SetUp]
        public void SetUp()
        {
            _field = Substitute.For<IField>();
        }


        [TestCase(true, 2u, 4u)]
        public void WonAmount_CorrectAmountReturned(bool fieldEven, uint amount, uint expected)
        {
            // Arrange
            _uut = new EvenOddBet("Svend", amount, true);
            _field.Even.Returns(fieldEven);

            // Act & Assert
            Assert.That(_uut.WonAmount(_field), Is.EqualTo(expected));
        }
    }
}
