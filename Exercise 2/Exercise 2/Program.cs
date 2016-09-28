using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime age = new DateTime(1992, 3, 24);
            DateTime age2 = new DateTime(1990, 9, 29);
            
            Person customer2 = new Person("Ernest", "Pascual","eepascual@gmail.com", age);
            Person customer3 = new Person("Barbie", "Albs", "", age2);
            
            customer2.printCustomerInfo();
            customer2.Adult();
            customer2.BirthdayToday();
            customer2.ScreenName();
            customer2.SunSign();
            customer2.ChineseSign();
            Console.WriteLine();
            Console.WriteLine();
            customer3.printCustomerInfo();
            customer3.Adult();
            customer3.BirthdayToday();
            customer3.ScreenName();
            customer3.SunSign();
            customer3.ChineseSign();
            Console.WriteLine();
            Console.WriteLine();
            Employees emp1 = new Employees("Ernest", "Pascual", "eepascual@gmail.com", age, 100021.12, "Manila");
            emp1.printEmployeeInfo();
            emp1.Adult();
            emp1.BirthdayToday();
            emp1.ScreenName();
            emp1.SunSign();
            emp1.ChineseSign();
            emp1.dues(1323123023.12);
            emp1.getAmount();
            emp1.addAmount(102120);
            


          

            Console.ReadKey();


           


        }
    }
}
