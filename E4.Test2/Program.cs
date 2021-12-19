using System;

namespace E4.Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("Calculator TEST:\n");
            Console.Write("----------------------------------------------\n");
            // Type your username and press enter
            Console.WriteLine("Enter number:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string number = Console.ReadLine();

            Console.Write("\n\n");

            // Call the calculate method
            Console.WriteLine("RESULT = " + Calculator.Add(number));

            Console.ReadKey(true);
        }

       
    }
}
