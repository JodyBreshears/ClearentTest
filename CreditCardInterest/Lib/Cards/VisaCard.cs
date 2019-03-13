using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib {
    public class VisaCard : Card {
        public VisaCard(string name, double balance, double rate) : base(name, balance, rate) { }
    }
}