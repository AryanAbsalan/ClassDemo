using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Student
    {

        //Public properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Default constructor.
        public Student()
        {

        }

        //Public method
        public void Display()
        {
            Console.WriteLine("\t Student first name:  " + this.FirstName);
            Console.WriteLine("\t Student last name:  " + this.LastName);
        }
    }
}
