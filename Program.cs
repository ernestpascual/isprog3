using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student student2 = new student();

            student1.studentId = "12341234";
            student1.firstName = "Jacob";
            student1.lastName = "Black";
            student1.Course = "BSIS";
            student1.year = 1;

            student2.studentId = "3324133";
            student2.firstName = "Jacobo";
            student2.lastName = "Blacko";
            student2.Course = "BSD";
            student2.year = 1;


            student1.PrintStudent();
            student2.PrintStudent();


        }


       
    }
}
