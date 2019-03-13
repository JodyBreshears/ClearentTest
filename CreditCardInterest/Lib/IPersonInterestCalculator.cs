using CreditCardInterestLib.Cards;

namespace CreditCardInterestLib
{
    public interface IPersonInterestCalculator
    {
        Person ComputeTotalInterestForPerson(IPerson person, int totalMonths);
        IWallet ComputeTotalInterestForWallet(IWallet wallet, int totalMonths);
        Card ComputeTotalInterestForCard(Card card, int totalMonths);
    }
}