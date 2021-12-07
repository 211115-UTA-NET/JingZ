using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// tutorial https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
namespace IntroToClasses
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }
        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }

}
