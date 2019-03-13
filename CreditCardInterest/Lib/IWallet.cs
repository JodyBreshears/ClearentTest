using System.Collections.Generic;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public interface IWallet {
        string Name { get; }
        ICollection<Card> Cards { get; }
    }
}