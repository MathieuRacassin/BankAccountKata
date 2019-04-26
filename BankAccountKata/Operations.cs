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

        public List<Operation> OperationList
        {
            get
            {
                return this.operations;
            }
        }

    }
}
