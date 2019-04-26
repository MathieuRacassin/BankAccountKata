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
            if (deposits.Count == 1)
                return deposits[0].GetDepositAmount();
            return 0.0;
        }

        public void MakeDeposit(Deposit deposit)
        {
            deposits.Add(deposit);
        }
    }
}