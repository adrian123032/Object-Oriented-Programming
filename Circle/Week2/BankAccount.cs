using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class BankAccount
    {

        public BankAccount()
        {
            Balance = 0;
            OpeningDate = DateTime.Now;

        }
      

        public BankAccount(string Iban, double Balance, User Owner): this() //when this constructor is called, the "this()" calls the parametless constructer to execute first
        {
            this.Iban = Iban;
            this.Balance = Balance;
            this.Owner = Owner;
            OpeningDate = DateTime.Now;

        }
        public enum AccountStatus { Active, Suspended, Frozen, Disabled, Closed }
        public string Iban { get; set; }
        protected double Balance { get; set; }
        public User Owner { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime? ClosingDate { get; set; }
        public AccountStatus Status { get; set; }

        public double withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;

            return Balance;

        }
        public double deposit(double amount)
        {
            Balance += amount;

            return Balance;

        }
    }
}
