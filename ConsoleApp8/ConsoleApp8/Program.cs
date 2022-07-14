using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Division division = new Division();
            Addition addition = new Addition();
            Substraction substraction = new Substraction();
            Multiplication multiplication = new Multiplication();

            Console.WriteLine(($"Division: first number={41}, second number={63}, result={division.Operate(41, 63)}"));
            Console.WriteLine($"Addition: first number={52}, second number={62}, result={addition.Operate(52, 62)}");
            Console.WriteLine($"Addition: first number={12}, second number={23}, result={substraction.Operate(12, 23)}");
            Console.WriteLine($"Addition: first number={14}, second number={73}, result={multiplication.Operate(14, 73)}");






        }
    }
}
