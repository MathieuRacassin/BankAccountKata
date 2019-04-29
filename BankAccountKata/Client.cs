namespace BankAccountKata
{
    public class Client
    {
        private BankAccount bankAccount;

        public Client()
        {
            this.bankAccount = new BankAccount();
        }

        private Client(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        public BankAccount BankAccount => bankAccount;

        public static Client CreateWithBankAccount(BankAccount bankAccount)
        {
            return new Client(bankAccount);
        }
    }
}