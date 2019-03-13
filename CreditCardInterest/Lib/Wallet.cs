using System.Collections.Generic;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public class Wallet : IWallet {
        public Wallet(string name, List<Card> cards) {
            Cards = cards;
            Name = name;
        }

        private Wallet(string name, List<Card> cards, double interest) : this(name, cards) {
            Interest = interest;
        }

        public string Name { get; }
        public ICollection<Card> Cards { get; }
        public double Interest { get; }

        public Wallet Clone( List<Card> cards,double interest) {
            return new Wallet(Name,cards,interest);
        }
    }
}