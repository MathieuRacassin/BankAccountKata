using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Operations
    {
        private List<Operation> operations;

        public Operations()
        {
            this.operations = new List<Operation>();
        }

        public void AddOperation(Operation operation)
        {
            this.operations.Add(operation);
        }

        public double OperationsSum()
        {
            double sum = 0;
            foreach (Operation operation in this.operations)
            {
                sum = sum + operation.GetOperationAmount();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder operations = new StringBuilder();
            foreach (Operation operation in this.operations)
            {
                operations.AppendLine(operation.ToString());
            }
            return operations.ToString();
        }

    }
}
