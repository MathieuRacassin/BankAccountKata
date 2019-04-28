using System;

namespace BankAccountKata
{
    public class Deposit : Operation
    {
        public Deposit(DateTime date, double amount):base(date, amount)
        {
        }
    }
}