using System;
using System.Collections.Generic;

namespace BankAccountKata
{
    public class BankAccount
    {
        private List<Deposit> deposits;

        public BankAccount()
        {
            this.deposits = new List<Deposit>();
        }

        public double GetAmount()
        {
            double amount = 0;
            foreach(Deposit deposit in this.deposits)
            {
                amount = amount + deposit.GetDepositAmount();
            }
            return amount;
        }

        public void MakeDeposit(Deposit deposit)
        {
            deposits.Add(deposit);
        }

    }
}