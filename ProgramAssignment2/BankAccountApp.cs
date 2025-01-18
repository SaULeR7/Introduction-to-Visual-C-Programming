using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProgramAssignment2
{
    internal class BankAccountApp
    {
        static void Main(string[] args)
        {
            WriteLine("First account" + "\n");
            BankAccount accountJohnC = new BankAccount("12345", "John", "C", 50.00);
            // Creates an account with $50 initial deposit for John C.  Note that numTransactions should be set to zero as well.
            accountJohnC.deposit(10.00);
            accountJohnC.deposit(50.00);
            accountJohnC.deposit(10.00);
            accountJohnC.deposit(70.00);
            accountJohnC.withdraw(100.00);
            accountJohnC.LastName = "Cool";
            WriteLine(accountJohnC.toString() + "\n");
            //Account info: John Cool, 12345 has a Balance = $90, with 5 transactions
            WriteLine("Second account" + "\n");

            BankAccount account2 = new BankAccount("54321", "Ivan", "Chukharev");
            account2.deposit(5000);
            WriteLine(account2.toString());
            ReadKey();
        }
    }
}
