using System;
using BankAccountKata;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKataTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void GetAmountWithNewBankAccountShouldHaveAmountZero()
        {
            BankAccount bankAccount = new BankAccount();

            double amount = bankAccount.GetAmount();

            amount.Should().Be(0);
        }

        [TestMethod]
        public void ClientMakesThreeDepositsOf10OnHisNewBankAccountGetAmountShouldGive30()
        {
            Client client = new Client();

            client.BankAccount.MakeDepositOf(10);
            client.BankAccount.MakeDepositOf(10);
            client.BankAccount.MakeDepositOf(10);

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(30);
        }

        [TestMethod]
        public void ClientMakesOneWithdrawalOf10GetAmountShouldGiveMinus10()
        {
            Client client = new Client();
            double withDrawalAmount = 10;

            client.BankAccount.MakeWithDrawalOf(withDrawalAmount);
            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(-10);
        }

        [TestMethod]
        public void ClientMakesTwoDepositsOf10AndTwoWithdrawalOfFiveGetAmountShould10()
        {
            Client client = new Client();
            client.BankAccount.MakeDepositOf(10);
            client.BankAccount.MakeWithDrawalOf(5);
            client.BankAccount.MakeDepositOf(10);
            client.BankAccount.MakeWithDrawalOf(5);

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(10);
        }
    }
}
