using System;
using System.Collections.Generic;

namespace BankAccountKata
{
    public class BankAccount
    {
        private Operations operations;

        public BankAccount()
        {
            this.operations = new Operations();
        }

        public double GetAmount()
        {
            double amount = 0;
            foreach(Operation operation in this.operations.OperationList)
            {
                amount = amount + operation.GetOperationAmount();
            }
            return amount;
        }

        public void MakeDeposit(Deposit deposit)
        {
            operations.OperationList.Add(deposit);
        }

        public double MakeWithDrawalOf(double withDrawalAmount)
        {
                return 10;
        }
    }
}