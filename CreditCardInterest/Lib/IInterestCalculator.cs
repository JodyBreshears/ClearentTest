using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib
{
    public interface IInterestCalculator
    {
        double ComputeTotalInterestForPerson(IPerson person, int totalMonths);
        double ComputeTotalInterestForWallet(int totalMonths, IWallet wallet);
        double ComputeTotalInterestForCard(Card card, int totalMonths);
    }
}