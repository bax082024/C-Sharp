using System;
using System.Net;

class Program
{

  static void Main(string[] args)
  {
    Calculator calculator = new Calculator();

    Console.WriteLine("Enter the first number.");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the second number");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("+, -, *, /");
    char operation = Convert.ToChar(Console.ReadLine());

    switch (operation)
    {
      case '+':
      Console.WriteLine($"Result: {calculator.AddNumbers(num1, num2)}");
      break;

      case '-':
      Console.WriteLine($"Result: {calculator.SubtractNumbers(num1, num2)}");
      break;

      case '*':
      Console.WriteLine($"Result {calculator.MultiplyNumbers(num1, num2)}");
      break;

      case '/':
      try{
      Console.WriteLine($"Result {calculator.DivideNumbers(num1, num2)}");
      }
      catch (DivideByZeroException ex)
      {
        Console.WriteLine(ex.Message);
      }
      break;

    default:
      Console.WriteLine("Invalid operation");
      break;

    }

  }
}
