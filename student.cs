using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    class student
    {
       public string studentId;
       public string lastName;
       public string firstName;
       private string course;
       public int year;

        public string Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value != "BSIS" && value != "BSBM")
                {
                    Console.WriteLine("Invalid Course");

                }
                else
                {
                    this.course = value;
                }
            }
        }


        public void PrintStudent()
        {
            Console.WriteLine("Student ID: " + this.studentId);
            Console.WriteLine("Last Name: " + this.lastName);
            Console.WriteLine("First Name: " + this.firstName);
            Console.WriteLine("Course: " + this.course);
            Console.WriteLine("Year: " + this.year);
        }


    }



    
}

