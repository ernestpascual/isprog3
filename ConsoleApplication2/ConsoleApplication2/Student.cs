using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student
    {
        public string StudentId { get; set; }

      
        /// <summary>
        ///  if not virutal it will not be overriden
        /// </summary>
        public virtual void PrintStudent()
        {
            Console.WriteLine("");
            Console.WriteLine("STUDENT ID: " + this.StudentId);
        
        }

        
    }

    class Scholar : Student
    {
        public decimal Allowance { get; set; }
      
        /*
         OVERRIDE

          public  override void PrintStudent()
        {
            base.PrintStudent();
            Console.Write("Allowance: " + this.Allowance);
        }
        */

        public new void PrintStudent()
        {
            base.PrintStudent();
            Console.Write("Allowance: " + this.Allowance);
        }


    }

 
}
