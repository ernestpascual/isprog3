using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    // IPayable Interface
        public interface IPayable
        {
            void getAmount();
            void addAmount(double add);
            void paymentAddress();
        }
    public class Person
    {
        

        //  Create a reference type called Person.  Populate the Person class with the following properties to store the following information
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        // Add constructors that accept the following parameter lists

        public Person() { }
        public Person (string fn, string ln, string em, DateTime bd) 
        {
            this.firstName = fn;
            this.lastName = ln;
            this.email = em;
            this.birthDate = bd;
        }

        public Person (string fn, string ln, string em)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.email = em;
        }

        public Person (string fn, string ln, DateTime bd) 
        {
            this.firstName = fn;
            this.lastName = ln;
            this.birthDate = bd;
        }


        // #3

        public void Adult ()
        {
            int age = 0;
            string adult;
            age = DateTime.Now.Year - this.birthDate.Year;

            if (age > 18)
            {
                adult = "adult";
            } else
            {
                adult = "not adult";
            }

            Console.WriteLine("You are " + adult+ ".");

        }


        public void SunSign ()
        {
            string sunsign = "";
            int month = this.birthDate.Month;
            int day = this.birthDate.Day;

            if (month == 3 && day >= 21 && day <= 31)
            {
                sunsign = "Aries";
            } else

            if(month == 4 && day ==1 && day >= 19)
            {
                sunsign = "Aries";
            } else

            if (month == 4 && day >= 20 && day <= 30)
            {
                sunsign = "Taurus";
            } else

            if (month == 5 && day >= 1 && day <= 20)
            {
                sunsign = "Taurus";
            } else

               if (month == 5 && day >= 21 && day <= 31)
            {
                sunsign = "Gemini";
            }

            if (month == 6 && day >= 1 && day <= 20)
            {
                sunsign = "Gemini";
            } else
            
            if (month == 6 && day >= 21 && day <= 30)
            {
                sunsign = "Cancer";
            }

            if (month == 7 && day >= 1 && day <= 22)
            {
                sunsign = "Cancer";
            } else

            if (month == 7 && day >= 23 && day <= 31)
            {
                sunsign = "Leo";
            } else

            if (month == 8 && day >= 1 && day <= 22)
            {
                sunsign = "Leo";
            } else

            if (month == 8 && day >= 23 && day <= 31)
            {
                sunsign = "Virgo";
            } else

            if (month == 9 && day >= 1 && day <= 22)
            {
                sunsign = "Virgo";
            } else

            if (month == 9 && day >= 23 && day <= 31)
            {
                sunsign = "Libra";
            } else

            if (month == 10 && day >= 1 && day <= 22)
            {
                sunsign = "Libra";
            } else

            if (month == 10 && day >= 23 && day <= 31)
            {
                sunsign = "Scorpio";
            } else

            if (month == 11 && day >= 1 && day <= 21)
            {
                sunsign = "Scorpio";
            } else
             
            if (month == 11 && day >= 22 && day <= 30)
            {
                sunsign = "Sagittarius";
            } else

            if (month == 12 && day >= 1 && day <= 21)
            {
                sunsign = "Sagittarius";
            } else

            if (month == 12 && day >= 22 && day <= 31)
            {
                sunsign = "Capricorn";
            } else

            if (month == 1 && day >= 1 && day <= 19)
            {
                sunsign = "Sagittarius";
            } else

            if (month == 1 && day >= 20 && day <= 31)
            {
                sunsign = "Aquarius";
            } else

            if (month == 2 && day >= 1 && day <= 18)
            {
                sunsign = "Aquarius";
            } else

            if (month == 2 && day >= 19 && day <= 29)
            {
                sunsign = "Pisces";
            } else

            if (month == 3 && day >= 1 && day <= 20)
            {
                sunsign = "Pisces";
            }

            Console.WriteLine("Your sun sign is " + sunsign + ".");

        }

        public void BirthdayToday ()
        {
            string birthday = "";
            if (this.birthDate.Month == DateTime.Now.Month)
            {
                if (this.birthDate.Day == DateTime.Now.Day)
                {
                    birthday = "It's Your birthday!!!";
                }
            }
            else
            {
                birthday = "Not your birthday today.";
            }

            Console.WriteLine(birthday);
        }


        public void ScreenName()
        {
            string sn = "";
            sn = this.firstName + this.lastName + this.birthDate.Year.ToString();

            Console.WriteLine("Your screen name is " + sn + ".");
        }

        public void ChineseSign()
        {
            string cs = "";
            string[] signs = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Ram" };
            int result = this.birthDate.Year % 12;
            cs = signs[result];
            Console.WriteLine("Your are born in the Year of the " + cs + ".");
            // modified from https://www.experts-exchange.com/questions/24978192/Need-to-calculate-chinese-zodiac.html

        }

        public void printCustomerInfo()
        {
            Console.WriteLine("=====CUSTOMER=====");
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Email: " + this.email);
            Console.WriteLine("Birthday: " + this.birthDate.Month.ToString() + "/" + this.birthDate.Day.ToString() + "/" + this.birthDate.Year.ToString());
            Console.WriteLine();
        }
    }

    public class Employees : Person, IPayable
    {
        public double salary { get; set; }
        public string mailingAddress { get; set; }

        private double mtracker { get; set; }

        // get amount, add amount, payment address

     

        public Employees(string fn, string ln, string em, DateTime bd, double sal, string ma)
            : base (fn, ln, em, bd)
        {
            this.salary = sal;
            this.mailingAddress = ma;
        }


      
        
        public void printEmployeeInfo()
        {
            Console.WriteLine("=====EMPLOYEE=====");
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
            Console.WriteLine("Email: " + this.email);
            Console.WriteLine("Birthday: " + this.birthDate.Month.ToString() + "/" + this.birthDate.Day.ToString() + "/" + this.birthDate.Year.ToString());
            Console.WriteLine("Salary: " + this.salary);
            Console.WriteLine("Mailing address: " + this.mailingAddress);
        }


        public void getAmount()
        {
            Console.WriteLine("Amount due to employee is :" + this.mtracker);
        }

        public void addAmount(double add)
        {
            double final = 0;
            final = this.mtracker + add;

            Console.WriteLine("Adding " + add.ToString() + " to previous due..");
            Console.WriteLine("Total amount due: " + final.ToString());
        }

        public void paymentAddress()
        {
            Console.WriteLine("Payment address is " + this.mailingAddress);
        }

        public void dues(double due)
        {
            this.mtracker = due;
        }
       
    }
}
