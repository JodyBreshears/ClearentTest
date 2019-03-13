namespace CreditCardInterestLib.Cards {
    public class MasterCard : Card {
        public MasterCard(string name, double balance, double rate) : base(name, balance, rate) {}
        private MasterCard(string name, double balance, double rate, double interest) : base(name, balance, rate, interest) { }

        public override Card Clone(double cardInterest) {
            return new MasterCard(Name, Balance, Rate, cardInterest);
        }
    }
}