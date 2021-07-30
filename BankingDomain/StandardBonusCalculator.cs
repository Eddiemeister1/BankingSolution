namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateBankAccountBonuses
    {
        public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            return (balance >= 10000) ? amountToDeposit * .10M : 0;
        }

    }
}