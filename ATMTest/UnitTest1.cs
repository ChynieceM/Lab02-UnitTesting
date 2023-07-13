using Lab02_UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = Lab02_UnitTesting.Program;

namespace ATMTest
{
    public class UnitTest1


    {
        [Theory]
        [InlineData(200, 200)]
        [InlineData(0, 0)]
        public void ViewBalanceShouldReturnStartingBalance(decimal startingBalance, decimal currentBalance)
        {
            
            Program.balance = startingBalance;

            Assert.Equal(startingBalance, currentBalance);
        }
        [Theory]
        [InlineData(-100,0)]
        [InlineData(100,100)]
        public void DepositShouldIncreaseBalance(decimal depositAmount,  decimal expectedBalance)
        {

           // decimal testBalance = startingBalance;
           //decimal expectedBalance = Program.ViewBalance();
          // expectedDepositAmount = Program.Deposit(depositAmount);
          Program.balance = 0m;
           decimal actualBalance = Program.Deposit(depositAmount);

            Assert.Equal(expectedBalance, actualBalance);
        }
        [Theory]
        [InlineData(100,100)]
        [InlineData(300, 200)]
        public void WithdrawShouldDecreaseBalance(decimal withdrawalAmount, decimal expectedBalance) 
        {
           
            Program.balance = 200m;
 

            decimal currentBalance = Program.Withdraw(withdrawalAmount);
            Assert.Equal(expectedBalance, currentBalance);
        }
    }
}