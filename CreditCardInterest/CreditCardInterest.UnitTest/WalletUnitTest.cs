using System.Collections.Generic;
using System.Linq;
using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.UnitTest
{
    [TestFixture]
    public class WalletUnitTest
    {
        [Test]
        public void When_WalletCreatedWithCard_CanGetCardFromList()
        {
            IWallet wallet= new Wallet("Wallet1", new List<Card>{new VisaCard("Card1",100,0.1)});
            Assert.That(wallet.Cards.FirstOrDefault().Name, Is.EqualTo("Card1"));
            Assert.That(wallet.Cards.FirstOrDefault() is VisaCard);
        }
    }
}