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
            //Console.WriteLine($"WithdrawCost is {BankAccount.WithdrawCost} ");
            Console.WriteLine(myBa);
            myBa.Deposit(200);
            Console.WriteLine(myBa);
            myBa.Withdraw(50);
            Console.WriteLine(myBa);

            foreach (var item in myBa.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }

            var mySa = new SavingsAccount("123-12312312-67", 0.01M);
            mySa.Deposit(1000);
            mySa.AddInterest();
            mySa.Withdraw(10);
            Console.WriteLine($"Balance of savingsAccount : {mySa.Balance}");
            foreach (var item in mySa.Transactions)
            {
                Console.WriteLine($"{item.Amount} -- {item.DateOfTransaction} -- {item.TransactionType}");
            }
            Console.ReadKey();//zodat console niet direct afsluit
        }
    }
}
