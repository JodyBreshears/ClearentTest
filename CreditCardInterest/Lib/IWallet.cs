using System.Collections.Generic;
using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public interface IWallet {
        string Name { get; }
        ICollection<Card> Cards { get; }
        double Interest { get; }
        Wallet Clone( List<Card> cards,double interest);
    }
}