﻿using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class MakingWithdrawals
    {
        [Fact]
        public void WithdrawingMoneyDecreasesTheBalance()
        {
            //Given
            var account = new BankAccount(new bonusCalculatorFakeDummy());
            var openingBalance = account.GetBalance();
            var amountToWithdraw = 10M;

            //When
            account.Withdraw(amountToWithdraw);

            //Then
            Assert.Equal(5000M - amountToWithdraw, account.GetBalance());
        }
    }
}
