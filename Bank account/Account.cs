using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    internal class Account
    {
        private string name;
        private double balance;
        public Account(string name, double money)
        {
            if (money < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative");
            }
            this.name = name;
            this.balance = money;
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Withdrawal(double money) {
            if (money > balance || money < 0)
            {
                Console.WriteLine($"You cannot take more money than you have, you have {balance}");
                return;
            }
            balance -= money;
            //Console.WriteLine("The event was successful\n");
        }
        public void Deposit(double money) {
            if (money < 0 )
            {
                Console.WriteLine("Deposit amount must be greater than zero");
                return;
            }
            balance += money;
            //Console.WriteLine("The event was successful\n");
        }

    }
}
