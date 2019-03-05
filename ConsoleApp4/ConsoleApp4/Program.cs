using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person spouse1 = new Person();
            Person person2 = new Person();
            Person spouse2 = new Person();
            Person.SumOfAllAges = 0;
            Person.AverageAge = 0;
            System.Console.WriteLine("Enter Information for Person1");
            System.Console.WriteLine();
            System.Console.Write("Enter your first Name                 :  ");
            person1.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter your Last Name                  :  ");
            person1.LastName = System.Console.ReadLine();
            System.Console.Write("Enter your Age                        :  ");
            person1.Age = int.Parse(System.Console.ReadLine());
           Person.SumOfAllAges = person1.Age;
            System.Console.Write("Enter your Spouse's First Name        : ");
            spouse1.FirstName = System.Console.ReadLine();
            person1.Spouse = spouse1.FirstName;
            System.Console.Write("Enter your Spouse's Age               :  ");
            spouse1.LastName = person1.LastName;
            spouse1.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += spouse1.Age;
            spouse1.Spouse = person1.FirstName;

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Enter Information for Person 2");
            System.Console.WriteLine();
            System.Console.Write("Enter your first Name                 :   ");
            person2.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter your last name                  :  ");
            person2.LastName = System.Console.ReadLine();
            spouse2.LastName = person2.LastName;
            System.Console.Write("Enter your Age                        :  ");
            person2.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += person2.Age;
            System.Console.Write("Enter your spouse's first name        :  ");
            spouse2.FirstName = System.Console.ReadLine();
            person2.Spouse = spouse2.FirstName;
            spouse2.Spouse = person2.FirstName;
            System.Console.Write("Enter your spouse's age               :  ");
            spouse2.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += spouse2.Age;
            Person.AverageAge = Person.SumOfAllAges / 4;

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            person1.PrintNameAndAge();
            spouse1.PrintNameAndAge();
            person2.PrintNameAndAge();
            spouse2.PrintNameAndAge();

            System.Console.WriteLine();
            System.Console.WriteLine("Average Age =" + Person.AverageAge);





            


     
            System.Console.ReadKey();




        }
    }
}
