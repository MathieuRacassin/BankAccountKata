namespace BankAccountKata
{
    public class Client
    {
        public BankAccount bankAccount;

        public Client()
        {
            this.bankAccount = new BankAccount();
        }

        public BankAccount BankAccount
        {
            get
            {
                return this.bankAccount;
            }
        }
    }
}