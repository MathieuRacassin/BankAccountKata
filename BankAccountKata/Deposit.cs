using System;

namespace BankAccountKata
{
    public class Deposit : Operation
    {

        public Deposit(double amount) : base(amount)
        {
        }

        public override double GetOperationAmount()
        {
            return base.amount;
        }
    }
}