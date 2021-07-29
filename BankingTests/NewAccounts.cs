﻿using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class NewAccounts
    {
        [Fact]
        public void NewAccountsHaveCorrectBalance()
        {
            // Given (arrange)
            var account = new BankAccount(new Mock<ICalculateBankAccountBonuses>().Object);

            //When (Act)
            decimal openingBalance = account.GetBalance();

            //Then (Assert)
            Assert.Equal(5000M, openingBalance);
        }
    }
}
