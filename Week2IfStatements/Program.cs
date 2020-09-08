using System;

namespace Week2IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string UserInput;

            Console.WriteLine("How old are you?");
            UserInput = Console.ReadLine();
            Age = Int32.Parse(UserInput);

            if (Age < 18)
            {
                Console.Write($"You are {Age}, you are too young.");
            } else if (Age > 18)
            {
                Console.WriteLine($"You are {Age}, you are old enough.");
            } else 
            {
                Console.WriteLine($"Congratualations! you are {Age}"); 

            }

        }
    }
}
