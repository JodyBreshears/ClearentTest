using System.Collections.Generic;
using System.Linq;
using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.UnitTest {
    [TestFixture]
    public class PersonUnitTest {
        [Test]
        public void When_PersonCreatedWithWallet_CanFindWalletInCollection() {
            Person person = new Person("Fred", new List<IWallet> { new Wallet("Wallet1", new List<Card>{new VisaCard("Visa1", 100, 0.1)})});
            Assert.That(person.Wallets.FirstOrDefault().Name, Is.EqualTo("Wallet1"));
        }
    }

}