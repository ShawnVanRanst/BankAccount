namespace BankingApp.Models.Domain
{
    public class SavingsAccount : BankAccount
    {
        private const decimal WithDrawCost = 0.10M;

        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, decimal interestRate):base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithDrawCost);
        }

        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }
    }
}
