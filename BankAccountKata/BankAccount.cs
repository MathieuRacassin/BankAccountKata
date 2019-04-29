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
            operations = new Operations();
        }

        private BankAccount(Operations operations)
        {
            this.operations = operations;
        }

        public double GetAmount()
        {
            return operations.OperationsSum();
        }

        public void MakeDepositOf(double depositAmount)
        {
            DateTime date = DateTime.UtcNow;
            Deposit deposit = new Deposit(date, depositAmount);

            operations.AddOperation(deposit);
        }

        public void MakeWithDrawalOf(double withDrawalAmount)
        {
            DateTime date = DateTime.UtcNow;
            Withdrawal withDrawal = new Withdrawal(date,withDrawalAmount);

            operations.AddOperation(withDrawal);
        }

        public string PrintOperationsHistoryBetween(DateTime from, DateTime to)
        {
            StringBuilder historyBuilder = new StringBuilder();

            historyBuilder.AppendLine("Bank Account History");
            historyBuilder.Append("From : ");
            historyBuilder.Append(from);

            historyBuilder.Append(" To : ");
            historyBuilder.Append(to);
            historyBuilder.AppendLine();

            historyBuilder.Append("Enable Amount : ");
            historyBuilder.Append(GetAmount());
            historyBuilder.AppendLine();

            historyBuilder.Append("Enable Balance : ");
            historyBuilder.Append(GetBalanceBetween(from, to));

            historyBuilder.AppendLine();
            historyBuilder.AppendLine(operations.GetOperationsBetween(from, to).ToString());

            return historyBuilder.ToString();
        }

        public string PrintCompleteOperationsHistory()
        {
            return PrintOperationsHistoryBetween(DateTime.MinValue, DateTime.MaxValue);
        }

        public static BankAccount CreateWithExistingOperations(Operations operations)
        {
            return new BankAccount(operations);
        }

        public double GetBalanceBetween(DateTime from, DateTime to)
        {
            return this.operations.GetOperationsBetween(from, to).OperationsSum();
        }
    }
}