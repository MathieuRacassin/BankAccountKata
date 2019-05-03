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
            operations = new List<Operation>();
        }

        public void AddOperation(Operation operation)
        {
            operations.Add(operation);
        }

        public double OperationsSum()
        {
            double sum = 0;
            foreach (Operation operation in operations)
            {
                sum += operation.Amount;
            }
            return sum;
        }

        public Operations GetOperationsBetween(DateTime from, DateTime to)
        {
            Operations newOperations = new Operations();
            foreach (Operation operation in operations)
            {
                if(operation.DateIsBetween(from, to))
                {
                    newOperations.AddOperation(operation);
                }
            }
            return newOperations;
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
