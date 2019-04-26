using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class WithDrawal : Operation
    {
        public WithDrawal(double amount) : base(-amount)
        {
        }

        public override double GetOperationAmount()
        {
            return base.amount;
        }
    }
}
