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
        public void NewBankAccountShouldHaveAmountZero()
        {
            BankAccount bankAccount = new BankAccount();

            double amount = bankAccount.GetAmount();

            amount.Should().Be(0);
        }
    }
}
