﻿using System;
using System.Text;
using BankAccountKata;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountKataTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void ClientWithNewBankAccountShouldHaveAmountZero()
        {
            Client client = Client.CreateClientWithNoBankAccount();

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(0);
        }

        [TestMethod]
        public void ClientMakesOneDepositOf10OnNewBankAccountGetAmountShouldGive10()
        {
            Client client = Client.CreateClientWithNoBankAccount();

            client.BankAccount.MakeDepositOf(10);

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(10);
        }

        [TestMethod]
        public void ClientMakesOneWithdrawalOf10OnNewBankAccountGetAmountShouldGiveMinus10()
        {
            Client client = Client.CreateClientWithNoBankAccount();

            client.BankAccount.MakeWithDrawalOf(10);

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(-10);
        }

        [TestMethod]
        public void ClientMakesOneDepositOf10OnExistingBankAccountGetAmountShouldGive20()
        {
            Client client = CreateClientWithExistingBankAccount();

            client.BankAccount.MakeDepositOf(10);

            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(20);
        }

        [TestMethod]
        public void ClientMakesOneWithdrawalOf10OnExistingBankAccountShouldGiveZero()
        {
            Client client = CreateClientWithExistingBankAccount();

            client.BankAccount.MakeWithDrawalOf(10);
            double amount = client.BankAccount.GetAmount();

            amount.Should().Be(0);
        }

        [TestMethod]
        public void ClientGetBalanceOfHisAccount()
        {
            Client client = CreateClientWithExistingBankAccount();
            DateTime from = new DateTime(2019, 04, 26);
            DateTime to = from.AddHours(6);

            double balance = client.BankAccount.GetBalanceBetween(from, to);

            balance.Should().Be(15);
        }

        [TestMethod]
        public void PrintCompleteHistoryShouldGiveTheBankAccountHistory()
        {
            Client client = CreateClientWithExistingBankAccount();

            string bankHistory = client.BankAccount.PrintCompleteOperationsHistory().Trim();

            StringBuilder bankHistoryExpected = new StringBuilder();
            bankHistoryExpected.AppendLine("Bank Account History");
            bankHistoryExpected.AppendLine("From : 01/01/0001 00:00:00 To : 31/12/9999 23:59:59");
            bankHistoryExpected.AppendLine("Enable Amount : 10");
            bankHistoryExpected.AppendLine("Enable Balance : 10");
            bankHistoryExpected.AppendLine("26/04/2019 02:00:00 10");
            bankHistoryExpected.AppendLine("26/04/2019 04:00:00 -5");
            bankHistoryExpected.AppendLine("26/04/2019 06:00:00 10");
            bankHistoryExpected.AppendLine("26/04/2019 08:00:00 -5");

            bankHistory.Should().Be(bankHistoryExpected.ToString().Trim());
        }

        [TestMethod]
        public void PrintCompleteHistoryBetweenTwoDatesShouldGiveTheBankAccountHistory()
        {
            Client client = CreateClientWithExistingBankAccount();

            DateTime from = new DateTime(2019, 04, 26);
            DateTime to = from.AddHours(6);

            string bankHistory = client.BankAccount.PrintOperationsHistoryBetween(from, to).Trim();

            StringBuilder bankHistoryExpected = new StringBuilder();
            bankHistoryExpected.AppendLine("Bank Account History");
            bankHistoryExpected.AppendLine("From : 26/04/2019 00:00:00 To : 26/04/2019 06:00:00");
            bankHistoryExpected.AppendLine("Enable Amount : 10");
            bankHistoryExpected.AppendLine("Enable Balance : 15");
            bankHistoryExpected.AppendLine("26/04/2019 02:00:00 10");
            bankHistoryExpected.AppendLine("26/04/2019 04:00:00 -5");
            bankHistoryExpected.AppendLine("26/04/2019 06:00:00 10");

            bankHistory.Should().Be(bankHistoryExpected.ToString().Trim());
        }

        private static Client CreateClientWithExistingBankAccount()
        {
            DateTime date = new DateTime(2019, 04, 26);

            Client client = Client.CreateClientWithNoBankAccount();

            Deposit deposit = new Deposit(date.AddHours(2), 10);
            Withdrawal withDrawal = new Withdrawal(date.AddHours(4), 5);
            Deposit deposit1 = new Deposit(date.AddHours(6), 10);
            Withdrawal withDrawal1 = new Withdrawal(date.AddHours(8), 5);

            Operations operations = new Operations();
            client.BankAccount.MakeDeposit(deposit);
            client.BankAccount.MakeWithDrawal(withDrawal);
            client.BankAccount.MakeDeposit(deposit1);
            client.BankAccount.MakeWithDrawal(withDrawal1);

            return client;
        }
    }
}
