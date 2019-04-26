using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public abstract class Operation
    {
        public double amount;

        public Operation(double amount)
        {
            this.amount = amount;
        }

        public abstract double GetOperationAmount();
    }
}
