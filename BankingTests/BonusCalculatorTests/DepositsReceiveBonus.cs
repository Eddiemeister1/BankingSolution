using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.BonusCalculatorTests
{
    public class DepositsReceiveBonus
    {

        [Fact]
        public void GoldAccountsReceiveABonus()
        {
            //This is declared like this so that calculator can only access the super methods and the ICalculateBankAccountBonuses methods that were overriden by StandardBonusCalculator
            ICalculateBankAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(10000, 100);

           
            Assert.Equal(10, bonus);
        }

        [Fact]
        public void NonGoldAccountsGetNoBonus()
        {
            ICalculateBankAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(9999.99M, 100);

            Assert.Equal(0, bonus);
        }
    }
}
