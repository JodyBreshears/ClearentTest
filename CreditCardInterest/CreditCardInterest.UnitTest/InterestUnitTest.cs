using System.Collections.Generic;
using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.UnitTest {
    [TestFixture]
    public class InterestUnitTest {
        [Test]
        public void When_SimpleInterestIs10_On3Cards_WalletTotalIs30() {
            IWallet wallet = new Wallet("Wallet1", new List<Card>
            {
                    new VisaCard("Visa1", 100,.1),
                    new MasterCard("MasterCard1",100,.1),
                    new DiscoverCard("DiscoverCard1", 100, .1)
                });
            SimpleInterestCalculator interestCalculator = new SimpleInterestCalculator();

            double totalInterest = interestCalculator.ComputeTotalInterestForWallet(1, wallet);

            Assert.That(totalInterest, Is.EqualTo(30).Within(.1));
        }

        [Test]
        public void When_SimpleInterestIs10_On3Cards_TotalIs30() {
            IPerson person = new Person(
                "Fred",
                new List<IWallet>{new Wallet("Wallet1",new List<Card>
                {
                    new VisaCard("Visa1", 100,.1),
                    new MasterCard("MasterCard1",100,.1),
                    new DiscoverCard("DiscoverCard1", 100, .1)
                })});
            SimpleInterestCalculator interestCalculator = new SimpleInterestCalculator();

            double totalInterest = interestCalculator.ComputeTotalInterestForPerson(person, 1);

            Assert.That(totalInterest, Is.EqualTo(30).Within(.1));
        }

        [Test]
        public void When_SimpleInterestIs10_On5CardsIn3Wallets_TotalIs50() {
            IPerson person = new Person(
                "Fred",
                new List<IWallet>{
                    new Wallet("Wallet1",new List<Card>(){
                            new VisaCard("Visa1", 100,.1),
                            new MasterCard("MasterCard1",100,.1),
                            new DiscoverCard("DiscoverCard1", 100, .1)
                        }),
                        new Wallet("Wallet2",new List<Card>{
                                new MasterCard("MasterCard1",100,.1),
                                new DiscoverCard("DiscoverCard1", 100, .1)
                            })
                    });
            SimpleInterestCalculator interestCalculator = new SimpleInterestCalculator();

            double totalInterest = interestCalculator.ComputeTotalInterestForPerson(person, 1);

            Assert.That(totalInterest, Is.EqualTo(50).Within(.1));
        }
    }
}