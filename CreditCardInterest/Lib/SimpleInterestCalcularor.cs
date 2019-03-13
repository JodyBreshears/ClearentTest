using System;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public class SimpleInterestCalculator : IInterestCalculator
    {
        public double ComputeTotalInterestForPerson(IPerson person, int totalMonths) {
            double totalInterest = 0.0;
            foreach (var wallet in person.Wallets) {
                totalInterest += ComputeTotalInterestForWallet(totalMonths, wallet);
            }
            Console.WriteLine($"{person.Name} has ${totalInterest} in interest");
            return totalInterest;
        }

        public double ComputeTotalInterestForWallet(int totalMonths, IWallet wallet) {
            double totalWalletInterest = 0.0;
            foreach (var card in wallet.Cards) {
                double cardInterest = ComputeTotalInterestForCard(card, totalMonths);
                Console.WriteLine($"    {wallet.Name} has a {card.GetType().Name} card with ${cardInterest} in interest.  Balance:{card.Balance}, Rate:{card.Rate}");
                totalWalletInterest += cardInterest;
            }
            Console.WriteLine($"  Wallet {wallet.Name} has {totalWalletInterest} in interest");
            return totalWalletInterest;
        }

        public  double ComputeTotalInterestForCard(Card card, int totalMonths) {
            return card.Rate * totalMonths * card.Balance;
        }
    }
}