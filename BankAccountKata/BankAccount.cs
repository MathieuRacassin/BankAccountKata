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

        private BankAccount(Operations operations)
        {
            this.operations = operations;
        }

        public double GetAmount()
        {
            return this.operations.OperationsSum();
        }

        public void MakeDepositOf(double depositAmount)
        {
            DateTime date = DateTime.MinValue;
            Deposit deposit = new Deposit(date, depositAmount);
            this.operations.AddOperation(deposit);
        }

        public void MakeWithDrawalOf(double withDrawalAmount)
        {
            DateTime date = DateTime.MinValue;
            Withdrawal withDrawal = new Withdrawal(date,withDrawalAmount);
            this.operations.AddOperation(withDrawal);
        }

        public string PrintOperationsHistory()
        {
            StringBuilder historyBuilder = new StringBuilder();

            historyBuilder.AppendLine("Bank Account History");
            historyBuilder.Append("Enable Amount : ");
            historyBuilder.Append(GetAmount());
            historyBuilder.AppendLine();
            historyBuilder.AppendLine(this.operations.ToString());

            return historyBuilder.ToString();
        }

        public static BankAccount CreateWithExistingOperations(Operations operations)
        {
            return new BankAccount(operations);
        }
    }
}