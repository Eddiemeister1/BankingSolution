using BankingDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingTests.ChangingFees
{
    public class FeesAreWithdrawnFromtheAccounts
    {
        [Fact]
        public void CanAssessFeesOnGroupsOfAccounts()
        {
            //Given
            var feeProcessor = new FeeProcessor();
            var mockedWithdrawThing = new Mock<ICanWithdrawFundsFromAnAccount>();

            feeProcessor.ChargeFee(mockedWithdrawThing.Object, 1.55M);

            //When

            //Then
            //Assert.Equal(openingBalance - 1.55M, account.GetBalance());
        }
    }
}
