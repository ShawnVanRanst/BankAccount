using BankingApp.Models.Domain;
using System;
using System.Collections.Generic;

namespace BankingApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Object Initializer
            //BankAccount anotherBA = new BankAccount()
            //{
            //    AccountNumber = "123-12312321-99",
            //    Balance = 200
            //};
            var myBa = new BankAccount("123-12312321-99", 50);
            Console.WriteLine($"Accountnumber is {myBa.AccountNumber} ");
            Console.WriteLine($"WithdrawCost is {BankAccount.WithdrawCost} ");
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Deposit(200);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");
            myBa.Withdraw(50);
            Console.WriteLine($"Balance is {myBa.Balance} Euro");

            foreach (var item in myBa.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }
            Console.ReadKey();//zodat console niet direct afsluit
        }
    }
}
