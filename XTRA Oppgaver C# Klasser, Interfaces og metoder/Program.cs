namespace Oppgaver_C__Klasser__Interfaces_og_metoder;

class Program
{
    static void Main(string[] args)
    {
        // fine kalkulator
        Console.WriteLine("Welcome to my calculator");        
        iCalculator calculator = new Calculator();

        
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Do you want to add, subtract, multiply, or divide? ");
        string operation = Console.ReadLine().ToLower();

        
        switch (operation)
        {
            case "add":
                double sum = calculator.Add(number1, number2);
                Console.WriteLine($"The sum of {number1} + {number2} is: {sum}");
                break;

            case "subtract":
                double difference = calculator.Subtract(number1, number2);
                Console.WriteLine($"The sum of {number1} - {number2} is: {difference}");
                break;

            case "multiply":
                double product = calculator.Multiply(number1, number2);
                Console.WriteLine($"The sum of {number1} * {number2} is: {product}");
                break;

            case "divide":
                double quotient = calculator.Divide(number1, number2);
                if (number2 != 0)
                {
                    Console.WriteLine($"the sum of {number1} / {number2} is: {quotient}");
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please type 'add', 'subtract', 'multiply', or 'divide'.");
                break;
        }

     
        
     Console.WriteLine("By using this calculator, you agreed to pay the maker 100$");
    }
    
}
