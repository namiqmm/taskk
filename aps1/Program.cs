using System;
using aps1;


namespace aps1
{
    public class Program
    {
        static void Main()
        {
            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();
            Division division = new Division();


            Console.WriteLine($"Addition: first number = {26}, second number = {3}. Result ={addition.Operate(26, 3)}");
            Console.WriteLine($"Substraction: first number = {14}, second number = {3}. Result ={substraction.Operate(14, 3)}");
            Console.WriteLine($"Multiplication: first number = {3}, second number = {8}. Result ={multiplication.Operate(3, 8)}");
            Console.WriteLine($"Division: first number = {22}, second number = {42}. Result ={division.Operate(22, 42)}");



        }
    }
}
