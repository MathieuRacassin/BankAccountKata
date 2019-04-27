using System;
using System.Collections.Generic;
using System.Text;

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

        public void MakeDepositOf(double depositAmount)
        {
            Deposit deposit = new Deposit(depositAmount);
            this.operations.AddOperation(deposit);
        }

        public void MakeWithDrawalOf(double withDrawalAmount)
        {
            WithDrawal withDrawal = new WithDrawal(withDrawalAmount);
            this.operations.AddOperation(withDrawal);
        }

        public string PrintOperationsHistory()
        {
            StringBuilder historyBuilder = new StringBuilder();

            historyBuilder.AppendLine("Bank Account History");
            historyBuilder.Append("Enable Amount : ");
            historyBuilder.Append(GetAmount());
            historyBuilder.AppendLine();


            foreach(Operation operation in this.operations.OperationList)
            {
                historyBuilder.Append(operation.ToString());
                historyBuilder.AppendLine();
            }

            return historyBuilder.ToString();
        }

    }
}