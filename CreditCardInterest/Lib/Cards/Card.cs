namespace CreditCardInterestLib.Cards {

    /// <summary>
    /// Note that this business of an abstract class is probably too fancy.  The cards might be Lazy Classes  We could do this with a simple CardType enumeration
    /// </summary>
    public abstract class Card {
        protected Card(string name, double balance, double rate) {
            Name = name;
            Balance = balance;
            Rate = rate;
        }

        protected Card(string name, double balance, double rate, double interest) : this(name, balance, rate) {
            Interest = interest;
        }

        public double Rate { get; }
        public double Balance { get; }
        public double Interest { get; }

        public string Name { get; }

        public abstract Card Clone(double cardInterest);
    }
}