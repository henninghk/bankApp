using System;
using System.Collections.Generic;
using System.Text;

namespace bankApp
{
    class BankAccount
    {
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }
    }
}
