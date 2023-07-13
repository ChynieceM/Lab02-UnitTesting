using Lab02_UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = Lab02_UnitTesting.Program;

namespace ATMTest
{
    public class UnitTest1


    {
        [Fact]
        public void ViewBalanceShouldReturnStartingBalance()
        {
            decimal startingBalance = 200m;
            decimal currentBalance = Program.ViewBalance();

            Assert.Equal(startingBalance, currentBalance);
        }
        [Fact]
        public void DepositShouldIncreaseBalance()
        {
            decimal depositAmount = 200m;
            decimal startingBalance = 0m;
            decimal expectedBalance = startingBalance + depositAmount;

            decimal currentBalance = Program.Deposit(depositAmount);

            Assert.Equal(expectedBalance, currentBalance);
        }
        [Fact]
        public void WithdrawShouldDecreaseBalance() 
        {
            decimal withdrawalAmount = 50m;
            decimal startingBalance = 200m;
            decimal expectedBalance = startingBalance - withdrawalAmount;

            decimal currentBalance = Program.Withdraw(withdrawalAmount);
            Assert.Equal(expectedBalance, currentBalance);
        }
    }
}