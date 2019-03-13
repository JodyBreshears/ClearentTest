using System.Collections.Generic;

namespace CreditCardInterestLib {
    public class Person : IPerson
    {

        public Person(string name, List<IWallet> list) {
            Wallets = list;
            Name = name;
        }

        private Person(string name, List<IWallet> wallets, double interest) : this(name, wallets)
        {
            Interest = interest;
        }

        public double Interest { get; }

        public string Name { get; }

        public List<IWallet> Wallets { get; }

        public Person Clone(List<IWallet> wallets, double interest)
        {
            return new Person(Name,wallets,interest);
        }
    }
}