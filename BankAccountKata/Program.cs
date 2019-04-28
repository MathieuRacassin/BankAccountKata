using System;

namespace BankAccountKata
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2019, 04, 26);
            Deposit deposit = new Deposit(date.AddHours(2), 10);
            Withdrawal withDrawal = new Withdrawal(date.AddHours(4), 5);

            Operations operations = new Operations();
            operations.AddOperation(deposit);
            operations.AddOperation(withDrawal);

            BankAccount bankAccount = BankAccount.CreateWithExistingOperations(operations);

            Client client = Client.CreateWithBankAccount(bankAccount);

            Console.WriteLine(client.BankAccount.PrintOperationsHistory());
            Console.ReadKey();
        }
    }
}
