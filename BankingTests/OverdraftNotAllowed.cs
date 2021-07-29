using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class OverdraftNotAllowed
    {

        // balance cannot go below zero.
        // account.withdraw(1000000);
        //- no money is taken from your account. 

        //a change!


        [Fact]
        public void OverdraftDoesNotDecreaseBalance()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            try
            {
                account.Withdraw(openingBalance + 1);
            }
            catch(OverdraftNotAllowedException)
            {
                //Gulp! I'm kind of expecting this, but I want to make sure we
                //didn't decrement the balance an overdraft.
            }
            

            Assert.Equal(openingBalance, account.GetBalance());
        }
        // we should throw an exception.

        [Fact]
        public void OverDraftThrowsException()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            Assert.Throws<OverdraftNotAllowedException>(
                () => account.Withdraw(openingBalance + 1)
                );
        }
    }
}
