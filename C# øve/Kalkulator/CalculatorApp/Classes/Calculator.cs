///<summary>
///Calculator class that implements the iCalculator interface
///<summary>
public class Calculator : ICalculate
{
  /// <inheritdoc/>
  public double AddNumbers(double a, double b)
  {
    return a + b;
  }


  ///<inheritdoc />
  public double SubtractNumbers(double a, double b)
  {
    return a - b;
  }

  ///<inheritdoc/>
  public double MultiplyNumbers(double a, double b)
  {
    return a * b;
  }

  ///<inheritdoc/>
  public double DivideNumbers(double a, double b)
  {
    if (b == 0)
      throw new DivideByZeroException("Cannot divide by zero.");
    return a / b;
  }
}