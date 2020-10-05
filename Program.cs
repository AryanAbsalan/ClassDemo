using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Example of defining a class in C# , setting its properties and calling its method/s.");

            // defining the first object of student class as tim
            Student tim = new Student();
            // setting the poblic attributes for the first object
            tim.FirstName = "Tim";
            tim.LastName = "Timmabc";


            // defining the second object of student class as jim
            Student jim = new Student();
            // setting the poblic attributes for the second object
            jim.FirstName = "Jim";
            jim.LastName = "Jimmxyz";

            //Calling the Display method for both objects
            tim.Display();
            jim.Display();

            Console.ReadKey();
        }
    }
}
