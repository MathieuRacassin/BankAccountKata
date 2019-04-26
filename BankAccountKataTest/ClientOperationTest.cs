﻿using System;
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


    }
}
