using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public abstract class Operation
    {
        private readonly DateTime date;

        public Operation(DateTime date, double amount)
        {
            this.date = date;
            this.Amount = amount;
        }

        public double Amount { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(date);
            stringBuilder.Append(" ");
            stringBuilder.Append(this.Amount);

            return stringBuilder.ToString();
        }

        public bool DateIsBetween(DateTime from, DateTime to)
        {
            return this.date >= from && this.date <= to;
        }
    }
}
