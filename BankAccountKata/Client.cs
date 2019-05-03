﻿namespace BankAccountKata
{
    public class Client
    {
        private Client()
        {
            BankAccount = new BankAccount();
        }

        public BankAccount BankAccount { get; }

        private Client(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }

        public static Client CreateWithBankAccount(BankAccount bankAccount)
        {
            return new Client(bankAccount);
        }

        public static Client CreateClientWithNoBankAccount()
        {
            return new Client();
        }
    }
}