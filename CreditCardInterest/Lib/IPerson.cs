using System.Collections.Generic;

namespace CreditCardInterestLib
{
    public interface IPerson
    {
        List<IWallet> Wallets { get; }
        string Name { get; }
        double Interest { get; }
        Person Clone(List<IWallet> wallets, double interest);
    }
}