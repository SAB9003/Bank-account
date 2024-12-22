﻿namespace Bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 0);


            heikkisAccount.Withdrawal(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.Balance +"\n");
            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.Balance);

        }
    }
}
