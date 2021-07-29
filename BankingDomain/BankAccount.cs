using System;

namespace BankingDomain
{
    public enum AccountType { Standard, Gold}
    public class BankAccount
    {
        private decimal _balance = 5000;

        public AccountType AccountType { get; set; } = AccountType.Standard;
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if(amountToWithdraw >= _balance)
            {
                throw new OverdraftNotAllowedException();
            } else
            {
                _balance -= amountToWithdraw;
            }

        }

        public void Deposit(decimal amountToDeposit)
        {
            var bonus = 0M;
            if(AccountType == AccountType.Gold)
            {
                bonus = amountToDeposit * .10M;
            }
            _balance += amountToDeposit + bonus;
        }
    }
}