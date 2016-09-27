using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public abstract class Person
    {

        //  Create a reference type called Person.  Populate the Person class with the following properties to store the following information
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        // Add constructors that accept the following parameter lists
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

        public string Adult (string adult)
        {
            int age = 0;
            age = DateTime.Now.Year - this.birthDate.Year;

            if (age > 18)
            {
                adult = "adult";
            } else
            {
                adult = "not adult";
            }

            return adult;
        }


        public string SunSign (string sunsign)
        {
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

            return sunsign;

        }

        public string BirthdayToday (string birthday)
        {
            if (this.birthDate.Month == DateTime.Now.Month)
            {
                if (this.birthDate.Day == DateTime.Now.Day)
                {
                    birthday = "It's Your birthday!!!";
                }
            }

            return birthday;
        }


        public string ScreenName (string sn)
        {
            sn = this.firstName + this.lastName + this.birthDate.Year.ToString();

            return sn;
        }

        public string ChineseSign (string cs)
        {
            string[] signs = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Ram" };
            int result = this.birthDate.Year % 12;
            cs = signs[result];
            return cs;
            // modified from https://www.experts-exchange.com/questions/24978192/Need-to-calculate-chinese-zodiac.html

        }
    }
}
