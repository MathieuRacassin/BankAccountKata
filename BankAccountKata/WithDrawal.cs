using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Withdrawal : Operation
    {
        public Withdrawal(DateTime date, double amount) : base(date, -amount)
        {
        }
    }
}
