using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class BankAccountInteractions
    {
        [Fact]
        public void TheBonusCalculatorIsUsedProperly()
        {
            var stubbedBonusesCalculator = new Mock<ICalculateBankAccountBonuses>();
            var account = new BankAccount(stubbedBonusesCalculator.Object);
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100;
            stubbedBonusesCalculator.Setup(calc => calc.GetDepositBonusFor(openingBalance, amountToDeposit))
                .Returns(42);

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit + 42, account.GetBalance());
        }
    }
}
