using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lab02_UnitTesting
{
    public class Program
    {
       
        public static decimal balance = 0m;

        public static decimal ViewBalance()
        {
            return balance;
        }

        public static decimal Withdraw(decimal amount)

        {
            //Console.WriteLine("How much would you like to withdraw?");
          //decimal withDrawalAmount = decimal.Parse( Console.ReadLine());
            if (amount < 0|| amount > balance)
            {

                Console.WriteLine("Please deposit funds.");
                return balance;
            }
            else
            {
                balance -= amount;
                Console.WriteLine("This is your new balance:" + balance);
                return balance;
            }

        }
        public static decimal Deposit(decimal amount)
        {
            //Console.WriteLine("How much would you like to deposit?");
           // decimal depositAmount = decimal.Parse(Console.ReadLine());
            if (amount < 0)
            {
                
                return balance;
               
            }
           else
            {
                balance += amount;

                Console.WriteLine("This is your new balance:" + balance);
                   
            }

            return balance;
        }

        public static void UserInterface()
        {
            Console.WriteLine("Starting Balance:" + ViewBalance());

            Console.WriteLine("How much would you like to deposit?");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Deposit(depositAmount);


            Console.WriteLine("How much would you like to withdraw?:");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            Withdraw(withdrawalAmount);


            Console.WriteLine("Here is your final balance:" + ViewBalance());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
        public static void Main(string[] args)
        {

            UserInterface();
        }
    }
}