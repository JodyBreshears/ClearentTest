using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib
{
    public class SimpleInterestCalculator
    {
        public double ComputeCardInterest(Card card, int totalMonths) {
            return card.Rate * totalMonths * card.Balance;
        }
    }
}