using System;
using NSubstitute;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Test.Unit
{
    [TestFixture]
    class FieldBetTestUnit
    {
        private FieldBet _uut;
        private IField _field;


        [SetUp]
        public void SetUp()
        {
            _field = Substitute.For<IField>();
        }

        [TestCase(2u, 2u, 36*2u)]
        public void WonAmount_CorrectAmountReturned(uint fieldNumber, uint amount, uint expected)
        {
            // Arrange
            _uut = new FieldBet("Svend", amount, 2u);
            _field.Number.Returns(2u);
            
            // Act & Assert
            Assert.That(_uut.WonAmount(_field), Is.EqualTo(expected));
        }

    }
}
