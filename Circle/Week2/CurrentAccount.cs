using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class CurrentAccount: BankAccount
    {

        public double FeeOnChequeTransaction { get; set; }

        public void ConvertChequeIntoEuros()
        {
            Balance = Balance - FeeOnChequeTransaction;
        }

    }
}
