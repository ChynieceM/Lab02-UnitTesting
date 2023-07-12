using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ATMTest
{
    public class UnitTest1


    {
        [Fact]
        public void ViewBalanceShouldReturnStartingBalance()
        {
            decimal startingBalance = 0m;
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
            decimal withdrawalAmount = 20m;
            decimal startingBalance = 70m;
            decimal expectedBalance = startingBalance - withdrawalAmount;

            decimal currentBalance = Program.Withdraw(withdrawalAmount);
            Assert.Equal(expectedBalance, currentBalance);
        }
    }
}