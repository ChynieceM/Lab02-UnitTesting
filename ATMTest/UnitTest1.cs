using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1,1);
        }
        decimal ViewBalance(decimal value)
        {
            Program.Deposit(value);
            Assert.Equal(value, Program.ViewBalance());
        }
    }
}