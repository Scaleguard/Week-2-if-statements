using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that accepts two numbers (integers)
             * and check whether they are equal or not and displays feedback.
             * 
             * int a
             * int b
             * if (a == b)
             */
            string UserInput1;
            string UserInput2;
            
            Console.WriteLine("What is the first number?");
            UserInput1 = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            UserInput2 = Console.ReadLine();
            
            int X;
            int Y;
            X = Int32.Parse(UserInput1);
            Y = Int32.Parse(UserInput2);

            if (X > Y)
            {
                Console.WriteLine($"{X} is bigger than {Y}");
            } else if (Y < X)
            {
                Console.WriteLine($"{Y} is bigger than {X}");
            } else
            {
                Console.WriteLine($"{X} and {Y} are equal");
            }
            

        }
    }
}
