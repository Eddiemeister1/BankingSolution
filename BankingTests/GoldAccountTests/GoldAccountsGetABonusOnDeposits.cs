using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.GoldAccountTests
{
    public class GoldAccountsGetABonusOnDeposits
    {
        [Fact]
        public void TheBonusIsAppliedToTheirBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
            account.AccountType = AccountType.Gold;

            account.Deposit(amountToDeposit);

            Assert.Equal(amountToDeposit + 10 + openingBalance, account.GetBalance());
        }
    }
}
