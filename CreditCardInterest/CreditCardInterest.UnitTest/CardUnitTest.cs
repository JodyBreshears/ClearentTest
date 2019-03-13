using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.UnitTest {
    [TestFixture]
    public class CardUnitTest {
        [Test]
        public void When_CardIsCreateWithName_Then_NamePropertyIsName() {
            Card visaCard = new VisaCard("CardName", 100, 0.1);
            Assert.That(visaCard.Name, Is.EqualTo("CardName"));
        }
    }
}