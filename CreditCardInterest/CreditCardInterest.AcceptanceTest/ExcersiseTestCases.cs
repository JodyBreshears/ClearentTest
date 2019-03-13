
using System.Collections.Generic;
using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.AcceptanceTest {
    [TestFixture]
    public class ExerciseTestCases {
        [Test]
        public void CaseOne() {
            IPerson person = new Person(
                "Fred",
                new List<IWallet>{new Wallet("Wallet1",new List<Card>
                {
                    new VisaCard("Visa1", 100,.1),
                    new MasterCard("MasterCard1",100,.1),
                    new DiscoverCard("DiscoverCard1", 100, .1)
                })});

            IPersonInterestCalculator interest = new FullPersonInterestCalculator(new SimpleInterestCalculator());

            IPerson newPerson = interest.ComputeTotalInterestForPerson(person, 1);
            Assert.That(newPerson.Interest, Is.EqualTo(30));
            Assert.That(newPerson.Wallets[0].Interest, Is.EqualTo(30));
            Assert.That(newPerson.Wallets[0].Cards[0].Interest, Is.EqualTo(10));
            Assert.That(newPerson.Wallets[0].Cards[1].Interest, Is.EqualTo(10));
            Assert.That(newPerson.Wallets[0].Cards[2].Interest, Is.EqualTo(10));
        }

        [Test]
        public void CaseTwo() {
            IPerson person = new Person(
                "Fred",
                new List<IWallet>()
                {
                    new Wallet("Wallet1",new List<Card>()
                    {
                        new VisaCard("Visa1", 100,.1),
                        new DiscoverCard("DiscoverCard1", 100, .1)
                    }),
                    new Wallet("Wallet2", new List<Card>()
                    {
                        new MasterCard("MasterCard1",100,.1)
                    })
                }
                );

            IPersonInterestCalculator interest = new FullPersonInterestCalculator(new SimpleInterestCalculator());

            IPerson newPerson = interest.ComputeTotalInterestForPerson(person, 1);
            Assert.That(newPerson.Interest, Is.EqualTo(30));
            Assert.That(newPerson.Wallets[0].Interest, Is.EqualTo(20));
            Assert.That(newPerson.Wallets[1].Interest, Is.EqualTo(10));
        }

        [Test]
        public void CaseThree() {
            IPerson fred = new Person(
                "Fred",
                new List<IWallet>()
                {
                    new Wallet("Wallet1",new List<Card>()
                    {
                        new VisaCard("Visa1", 100,.1),
                        new MasterCard("MasterCard1", 100, .1)
                    })
                }
            );

            IPerson george = new Person(
                "George",
                new List<IWallet>()
                {
                    new Wallet("Wallet1",new List<Card>()
                    {
                        new VisaCard("Visa1", 100,.1),
                        new MasterCard("MasterCard1", 100, .1)
                    }),

                }
            );
            IPersonInterestCalculator interest = new FullPersonInterestCalculator(new SimpleInterestCalculator());

            IPerson newFred = interest.ComputeTotalInterestForPerson(fred, 1);
            IPerson newGeorge = interest.ComputeTotalInterestForPerson(george, 1);
            Assert.That(newFred.Interest, Is.EqualTo(20));
            Assert.That(newFred.Wallets[0].Interest, Is.EqualTo(20));

            Assert.That(newGeorge.Interest, Is.EqualTo(20));
            Assert.That(newGeorge.Wallets[0].Interest,Is.EqualTo(20));
        }



    }


}
