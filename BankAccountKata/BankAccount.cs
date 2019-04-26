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

        public void MakeDeposit(double depositAmount)
        {
            Deposit deposit = new Deposit(depositAmount);
            this.operations.AddOperation(deposit);
        }

        public double MakeWithDrawalOf(double withDrawalAmount)
        {
            WithDrawal withDrawal = new WithDrawal(withDrawalAmount);
            this.operations.AddOperation(withDrawal);

            return withDrawalAmount;
        }

    }
}