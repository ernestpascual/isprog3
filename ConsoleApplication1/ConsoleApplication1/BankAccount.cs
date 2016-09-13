using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BankAccount
    {
        private string accountNumber;
        private string accountName;
        private string accountType;
        private double accountBalance;
 

        public void CreateAccount(string accNum, string accName, string accType)
        {

            if (accType != "SA" && accType != "CA")
            {
                this.accountType = "Invalid!";

            } else
            {
                this.accountType = accType;
            }

            this.accountNumber = accNum;
            this.accountName = accName;


        }


        public void Deposit(double depositValue)
        {
            this.accountBalance += depositValue;

        }


        public void Withdraw(double withdrawValue)
        {
            this.accountBalance -= withdrawValue;

        }




        public void PrintInfo()
        {
            Console.WriteLine("Account number: " + this.accountNumber);
            Console.WriteLine("Account name: " + this.accountName);
            Console.WriteLine("Account type: " + this.accountType);
            Console.WriteLine("Account balance: " + this.accountBalance);
            Console.WriteLine("");

        }

  
    }
}
