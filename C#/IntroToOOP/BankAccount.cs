using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// tutorial https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
namespace IntroToClasses    // organize classes, group all classes from different file
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;  // static: shared by all of the BankAccount objects
        private List<Transaction> allTransactions = new List<Transaction>();
        private readonly decimal minimumBalance;
        // properties: getter & setter
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                // loop the transaction and added each transaction
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // constructor:  initialize objects of that class type
        //               called when you create an object using new
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            this.Number = accountNumberSeed.ToString(); // each time a new user create an account, acc# will be different
            accountNumberSeed++;    // here using increase by one each time created account.

            this.Owner = name;
            this.minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");   // DateTime.now: returns the current date and time.
        }

        // methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            var overdraftTransaction = CheckWithdrawalLimit(Balance - amount < minimumBalance);
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();   // StringBuilder: changable string

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
        // polymorthism: overriding
        public virtual void PerformMonthEndTransactions() { }
    }
}
