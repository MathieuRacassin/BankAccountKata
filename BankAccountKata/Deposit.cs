using System;

namespace BankAccountKata
{
    public class Deposit
    {
        private double deposit;

        public Deposit(double deposit)
        {
            this.deposit = deposit;
        }

        public double GetDepositAmount()
        {
            return this.deposit;
        }
    }
}