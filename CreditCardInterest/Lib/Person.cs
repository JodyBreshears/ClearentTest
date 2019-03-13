using System.Collections.Generic;

namespace CreditCardInterestLib {
    public class Person : IPerson
    {

        public Person(string name, List<IWallet> list) {
            Wallets = list;
            Name = name;
        }

        public string Name { get; }
        public ICollection<IWallet> Wallets { get; }
    }
}