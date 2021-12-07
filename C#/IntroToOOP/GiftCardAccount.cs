using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// tutorial https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
namespace IntroToClasses
{

    public class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;   // optional amount to add each month
        // the constructor provides a default value for the monthlyDeposit value so callers can omit a 0 for no monthly deposit
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;
        // => use for one line of code
        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
