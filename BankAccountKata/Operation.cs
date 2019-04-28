using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public abstract class Operation
    {
        protected DateTime date;
        protected double amount;

        public Operation(DateTime date, double amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public double GetOperationAmount()
        {
            return this.amount;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.date);
            stringBuilder.Append(" ");
            stringBuilder.Append(this.amount);

            return stringBuilder.ToString();
        }
    }
}
