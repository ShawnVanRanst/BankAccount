using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Models.Domain
{
    public class BankAccount
    {
        //private string _accountNumber;
        #region Fields
        public const decimal WithdrawCost = 0.10M;
        private decimal _balance;
        private ICollection<Transaction> _transactions;
        #endregion
        #region Properties
        public string AccountNumber { get;  set; }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
             private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negative balance is allowed");
                }

                _balance = value;
            }
        }

        public IEnumerable<Transaction> Transactions { get { return _transactions; } }
        #endregion

        #region Constructors

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber)
        {
            Balance = balance;
        }
        #endregion

        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        public override string ToString()
        {
            return $"{AccountNumber} -- {Balance}";
        }

        public override bool Equals(object obj)
        {
            BankAccount ba = obj as BankAccount;
            if(ba == null)
            {
                return false;
            }
            return AccountNumber == ba.AccountNumber;
        }

        public override int GetHashCode()
        {
            return AccountNumber.GetHashCode();
        }
        #endregion

    }
}
