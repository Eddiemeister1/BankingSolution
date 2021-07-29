using System;

namespace BankingDomain
{
    public class BankAccount : ICanWithdrawFundsFromAnAccount
    {
        private decimal _balance = 5000;
        private readonly ICalculateBankAccountBonuses _bonusCalculator;

        public BankAccount(ICalculateBankAccountBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw >= _balance)
            {
                throw new OverdraftNotAllowedException();
            }
            else
            {
                _balance -= amountToWithdraw;
            }

        }

        public virtual void Deposit(decimal amountToDeposit)
        {
            //WTCYWYH - "Write the Code You Wish You Had" <---REMEMBER THIS!!! VERY IMPORTANT!!!!
            decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;
        }
    }
}