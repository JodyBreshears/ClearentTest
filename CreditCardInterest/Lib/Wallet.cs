using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public class Wallet : IWallet
    {


        public Wallet(string name, List<Card> cards) {
            Cards = cards;
            Name = name;
        }

        public string Name { get; }
        public ICollection<Card> Cards { get; }
    }
}