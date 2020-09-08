using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that asks the users year of birth
             * and decides if the user is old enough to get a permanent driving license.
             */
            int YearOfBirth;
            string Userinput;
            Console.WriteLine("What year were you born in?");
            Userinput = Console.ReadLine();
            YearOfBirth = Int32.Parse(Userinput);
            int Age = 2020 - YearOfBirth; 

            if (Age > 18)
            {
                Console.WriteLine($"You are {Age}, you are old enough to get a permanent drivers license.");
            } else if (Age < 18)
            {
                Console.WriteLine($"You are {Age}, you are not old enough to get a permanent drivers license.");
            } else
            {
                Console.WriteLine($"You are {Age}, you are old enought to get a permanent drivers license.");
            }




        }
    }
}
