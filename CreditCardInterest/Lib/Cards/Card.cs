namespace CreditCardInterestLib.Cards {

    /// <summary>
    /// Note that this business of an abstract class is probably too fancy.  The cards might be Lazy Classes  We could do this with a simple CardType enumeration
    /// </summary>
    public abstract class Card {
        public double Rate { get;  }
        public double Balance { get;  }

        protected Card(string name, double balance, double rate) {
            Name = name;
            Balance = balance;
            Rate = rate;
        }

        public string Name { get; }
    }
}