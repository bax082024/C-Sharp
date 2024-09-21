///<summary>
///Interface for calculator operations
///<summary>
public interface ICalculate
{
    ///<summary>
    ///Adds two numbers.
    ///<summary>
    ///<param name="a">The first number.</param>
    ///<param name="b">The second number.</param>
    ///<returns>The sum of the two numbers.</returns>
    double AddNumbers(double a, double b);

    ///<summary>
    ///Subtracts the second number from the first number
    ///<summary>
    ///<param name="a">The first number.</param>
    ///<param name="b">The second number.</param>
    ///<returns>The difference between the two numbers.</returns>
    double SubtractNumbers(double a, double b);

    /// <summary>
    /// Multiply the first number with the second.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>the sum of the numbers multiplied</returns>
    double MultiplyNumbers(double a, double b);

    /// <summary>
    /// Divide the first number with the second.
    /// </summary>
    /// <param name="a">The first number</param>
    /// <param name="b">The second number</param>
    /// <returns>The sm of the first number divided by the secon number</returns>
    double DivideNumbers(double a, double b);

}