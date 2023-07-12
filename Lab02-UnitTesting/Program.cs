namespace Lab02_UnitTesting
{
    internal class Program
    {
        private static decimal balance = 0m;
            public static decimal ViewBalance()
        {
            return balance;
        }

        public static decimal Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                return balance;
            }else
            {
                return balance - amount;
            }
            
        }
        public static decimal Deposit(decimal amount) 
        {
            if (amount < 0)
            {
                return balance;
            }else if (amount > 0)
            {
                return balance + amount;
            }
            
        }
        public static void UserInterface()
        {
           Console.WriteLine(ViewBalance());
            Console.WriteLine(Deposit(20m));
            Console.WriteLine(ViewBalance());
            Console.WriteLine(Withdraw(20m));
            Console.WriteLine(ViewBalance());

        }
    }
}