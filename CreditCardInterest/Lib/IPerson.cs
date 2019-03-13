using System.Collections.Generic;

namespace CreditCardInterestLib
{
    public interface IPerson
    {
        ICollection<IWallet> Wallets { get; }
        string Name { get; }
    }
}