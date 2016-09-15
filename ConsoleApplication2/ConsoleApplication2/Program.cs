using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
                /// Inheritance
            Student regular = new Student();
            regular.StudentId = "10283";
            ///regular.PrintStudent();
            PrintAnyStudent(regular);



            Scholar acadaemic1 = new Scholar();
            acadaemic1.StudentId = "9382872";
            acadaemic1.Allowance = 323.12M;
            ///acadaemic1.PrintStudent();
            PrintAnyStudent(acadaemic1);

            Console.Read();

       


        }
        static void PrintAnyStudent(Student x)
        {
            x.PrintStudent();

        }
    }
}
