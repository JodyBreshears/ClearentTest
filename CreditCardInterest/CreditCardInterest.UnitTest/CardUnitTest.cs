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

//        [Test]
//        public void BalancePropertyIsSetable() {
//            Card visaCard = new VisaCard("CardName", 100, 0.1);
//            visaCard.Balance = 100;
//            Assert.That(visaCard.Balance, Is.EqualTo(100).Within(.001));
//        }
//
//        [Test]
//        public void InterestRateIsSetable()
//        {
//            Card visaCard = new VisaCard("CardName", 100, 0.1);
//            visaCard.Rate = .01;
//            Assert.That(visaCard.Rate,Is.EqualTo(.01).Within(.001));
//        }
    }
}