using System;

namespace aps
{
    class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();
            Division division = new Division();

            Console.WriteLine($"Addition: first number = {2}, second number = {14} Result = {addition.Operate}");
            Console.WriteLine($"first number = {21}, second number = {84} Result = {substraction.Operate}");
            Console.WriteLine($"first number = {42}, second number = {34} Result = {multiplication.Operate}"};
            Console.WriteLine($"first number = {58}, second number = {41} Result = {division.Operate}");






















        }

    }
}












