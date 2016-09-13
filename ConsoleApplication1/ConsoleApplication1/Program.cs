using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount customer1 = new BankAccount();
            BankAccount customer2 = new BankAccount();
            customer1.CreateAccount("1837234", "Ernest Pascual", "aA");
            customer1.Deposit(10001230.12);
            customer1.Withdraw(10201);

            customer2.CreateAccount("1837234", "Jacob C", "SA");
            customer2.Deposit(10001230.12);
            customer2.Withdraw(10201);


            customer1.PrintInfo();
            customer2.PrintInfo();

            Console.ReadLine();



        }
    }
}
