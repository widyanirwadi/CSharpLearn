using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }

        public double Balance { get; set; }

        public static void Withdraw(double Balance, double Amount)
        {
           BankAccount.CurrentBalance(Balance - Amount);
        }

        public static void Deposit (double Balance, double Amount)
        {
            BankAccount.CurrentBalance(Balance + Amount);
        }

        public static void CurrentBalance(double Balance)
        {
            Console.WriteLine("Your current balance is {0}", Balance);
        }
    }
}
