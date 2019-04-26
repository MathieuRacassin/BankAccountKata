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
        public void GetAmountWithOneDepositShouldGiveTheDepositAmount()
        {
            BankAccount bankAccount = new BankAccount();
            Deposit deposit = new Deposit(10);

            bankAccount.MakeDeposit(deposit);

            double amount = bankAccount.GetAmount();

            amount.Should().Be(10);
        }

        [TestMethod]
        public void GetAmountOnNewBankAccountWithThreeDepositsShouldGiveTheSumOfTheThreeDeposits()
        {
            BankAccount bankAccount = new BankAccount();
            Deposit deposit1 = new Deposit(10);
            Deposit deposit2 = new Deposit(10);
            Deposit deposit3 = new Deposit(10);

            bankAccount.MakeDeposit(deposit1);
            bankAccount.MakeDeposit(deposit2);
            bankAccount.MakeDeposit(deposit3);

            double amount = bankAccount.GetAmount();

            amount.Should().Be(30);
        }

        [TestMethod]
        public void ClientMakeOneDepositOnHisBankAccount()
        {
            Client client = new Client();
            Deposit deposit1 = new Deposit(10);

            client.BankAccount.MakeDeposit(deposit1);

            double amount = client.BankAccount.GetAmount();
            amount.Should().Be(10);
        }


    }
}
