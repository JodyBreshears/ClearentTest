using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public class VisaCard : Card {
        public VisaCard(string name, double balance, double rate) : base(name, balance, rate) { }

        private VisaCard(string name, double balance, double rate, double interest) : base(name, balance, rate, interest) { }

        public override Card Clone(double cardInterest) {
            return new VisaCard(Name, Balance, Rate, cardInterest);
        }
    }
}