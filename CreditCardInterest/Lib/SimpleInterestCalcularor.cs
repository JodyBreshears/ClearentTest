using System;
using System.Collections.Generic;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    /// <summary>
    /// Still not sure I like this name, but the point here is to have one class allowed intimate knowledge of person/wallet/card structure, and another class
    /// to the actual interest calculation separate from and ignorant of this structure.
    /// </summary>
    public class FullPersonInterestCalculator : IPersonInterestCalculator {
        private readonly SimpleInterestCalculator _interestCalculator;

        public FullPersonInterestCalculator(SimpleInterestCalculator interestCalculator)
        {
            _interestCalculator = interestCalculator;
        }

        public Person ComputeTotalInterestForPerson(IPerson person, int totalMonths)
        {
            var result = ComputePersonInterest(person, totalMonths);
            return person.Clone(result.wallets, result.interest);
        }

        private (List<IWallet> wallets, double interest) ComputePersonInterest(IPerson person, int totalMonths) {
            double totalInterest = 0.0;
            List<IWallet> newWallets = new List<IWallet>();
            foreach (var wallet in person.Wallets)
            {
                var newWallet = ComputeTotalInterestForWallet(wallet, totalMonths);
                totalInterest += newWallet.Interest;
                newWallets.Add(newWallet);
            }
            Console.WriteLine($"{person.Name} has ${totalInterest} in interest");
            return (wallets:newWallets,interest:totalInterest);
        }



        public Card ComputeTotalInterestForCard(Card card, int totalMonths) {
            return card.Clone(_interestCalculator.ComputeCardInterest(card, totalMonths));
        }

 
        public IWallet ComputeTotalInterestForWallet(IWallet wallet, int totalMonths) {
            var result = ComputeWalletInterest(totalMonths, wallet);
            return wallet.Clone(result.cards, result.interest);
        }

        private (List<Card> cards, double interest) ComputeWalletInterest(int totalMonths, IWallet wallet) {
            double totalWalletInterest = 0.0;
            List<Card> newcards = new List<Card>();
            foreach (var card in wallet.Cards) {
                var newCard = ComputeTotalInterestForCard(card, totalMonths);
                Console.WriteLine($"    {wallet.Name} has a {card.GetType().Name} card with ${newCard.Interest} in interest.  Balance:{card.Balance}, Rate:{card.Rate}");
                totalWalletInterest += newCard.Interest;
                newcards.Add(newCard);
            }
            Console.WriteLine($"  Wallet {wallet.Name} has {totalWalletInterest} in interest");
            return (cards: newcards, interest: totalWalletInterest);
        }

//        private double ComputeCardInterest(Card card, int totalMonths) {
//            return card.Rate * totalMonths * card.Balance;
//        }

    }
}