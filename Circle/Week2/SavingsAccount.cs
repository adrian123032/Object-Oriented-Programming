using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class SavingsAccount: BankAccount //Inheritance - means that the class in question is inheriting all public or protected members of the base class
    {
        public SavingsAccount(string Iban, double balance, User owner, double interestRate)
            :base(Iban, balance, owner)
        {
            InterestRate = interestRate;

        }
       public double InterestRate { get; set; }

        public double CalculateInterest()
        {
            return Balance * (InterestRate / 100);
        }

    }
}
