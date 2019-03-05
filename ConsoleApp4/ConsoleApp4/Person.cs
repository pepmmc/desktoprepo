using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public string Spouse;

        public static double SumOfAllAges;
        public static double AverageAge;
        public string GetFullName()
        {
            return LastName + ", " + FirstName;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + "  " + "  (" + Age + ")");




        }
        
    }
}
