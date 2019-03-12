using CreditCardInterestLib;
using NUnit.Framework;

namespace CreditCardInterest.UnitTest {
    [TestFixture]
    public class CardUnitTest {
        [Test]
        public void When_CardIsCreateWithName_Then_NamePropertyIsName() {
            Card card = new Card("CardName");
            Assert.That(card.Name, Is.EqualTo("CardName"));
        }
    }
}