
using System.Collections.Generic;
using CreditCardInterestLib;
using CreditCardInterestLib.Cards;
using NUnit.Framework;

namespace CreditCardInterest.AcceptanceTest
{
    [TestFixture]
    public class ExerciseTestCases {
        [Test]
        public void CaseOne()
        {
            IPerson person = new Person(
                "Fred",
                new List<IWallet>{new Wallet("Wallet1",new List<Card>
                {
                    new VisaCard("Visa1", 100,.1),
                    new MasterCard("MasterCard1",100,.1),
                    new DiscoverCard("DiscoverCard1", 100, .1)
                })});

            IInterestCalculator interest = new SimpleInterestCalculator();

            Assert.That(interest.ComputeTotalInterestForPerson(person,1), Is.EqualTo(30));
            //Assert.That(interest.ComputeTotalInterestForCard(person, 1), Is.EqualTo(30));

        }

           
    }


}