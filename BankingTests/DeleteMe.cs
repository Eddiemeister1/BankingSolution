using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests
{
    public class DeleteMe
    {
        [Fact]
        public void WithdrawingOnAnActualAccount()
        {
            var account = new BankAccount(null);
            var processor = new FeeProcessor();
            var openingBalance = account.GetBalance();

            processor.ChargeFee(account, 100);

            Assert.Equal(openingBalance - 100M, account.GetBalance());
        }

        [Fact]
        public void CanChargeCDSAFee()
        {
            var account = new CertificateOfDepMakingDeposits();
            var processor = new FeeProcessor();

            //processor.ChargeFee(account, 100);

            //Assert.Equal(openingBalance - 100M, 
        }
    }
}
