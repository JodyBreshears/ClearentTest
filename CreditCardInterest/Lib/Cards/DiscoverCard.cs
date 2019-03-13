namespace CreditCardInterestLib.Cards {
    public class DiscoverCard : Card {
        public DiscoverCard(string name, double balance, double rate) : base(name, balance, rate) { }

        private DiscoverCard(string name, double balance, double rate, double interest) : base(name, balance, rate, interest) { }

        public override Card Clone(double cardInterest) {
            return new DiscoverCard(Name, Balance, Rate, cardInterest);
        }
    }
}