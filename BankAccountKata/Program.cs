using System;

namespace BankAccountKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.BankAccount.MakeDepositOf(10);
            client.BankAccount.MakeWithDrawalOf(5);

            Console.WriteLine(client.BankAccount.PrintOperationsHistory());
            Console.ReadKey();
        }
    }
}
