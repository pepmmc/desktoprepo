using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //DECLARING VARIABLES  
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightinches;
            double totalHeightCM;

            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();
            fullName = firstName + " " + middleInitial + ". " + lastName;

            //part two

            System.Console.Write("How many feet tall are you, rounding off the inches?");
            heightFeet=System.Console.ReadLine();
            System.Console.Write("How many inches do you extend beyond that base height?");
            heightinches = System.Console.ReadLine();
            totalHeightCM=((heightFeet*12)+(heightinches))*2.54;
            //part three
            System.Console.Write("Nice to meet you " + fullName + "; what is your age, friend?");
            age=int.Parse.System.Console.ReadLine();
            System.Console.Write("Are you a US citizen?");
            isCitizen=bool.Parse.readline();
            canVote = isCitizen && age >= 18;

            system.console.writeline(fullName);
            system.Console.writeline(totalHeightCM);
           System.Console.writeline(canVote);



            
        }
    }
}

      

            
