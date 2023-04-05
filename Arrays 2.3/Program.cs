using System;

class Program
{
    static void Main(string[] args)
    {
        double number1 = GetNumberInput();
        double number2 = GetNumberInput();
        double result  = (CheckNumbers(number1, number2));
        Console.WriteLine($"The larger number is {result}");

    }
    public static double CheckNumbers(double number1 , double number2)
    {
        if(number1 > number2) {
            return number1;
        }
        else
        {
            return number2;
        }
    }


    public static double GetNumberInput()
    {
        Console.Write("Enter a number : ");
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid number!");
            Console.Write("Enter number : ");
        }

        return number;


    }
}
