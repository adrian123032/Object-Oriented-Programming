using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {

            User u = new User();
            u.name = "dsad"; 
            SavingsAccount mySavingAccount = new SavingsAccount("515515151", 5155, u, 5);
            double Interest = mySavingAccount.CalculateInterest();
            Console.WriteLine(Interest);
            
            


            BankAccount b = new BankAccount("51541515411", 100, u);
            mySavingAccount.withdraw(100);
            Console.ReadKey();

        }
    }
}
