public interface iCalculator 
{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="a">the value of the number</param>
  /// <param name="b">the value of the number</param>
  /// <returns>a + b hopefully</returns>
  double Add(double a, double b);

/// <summary>
/// 
/// </summary>
/// <param name="a">value of number a</param>
/// <param name="b">value of number b</param>
/// <returns>a - b</returns>
  double Subtract(double a, double b);

/// <summary>
/// 
/// </summary>
/// <param name="a">value of a</param>
/// <param name="b">value of b</param>
/// <returns>a * b</returns>
  double Multiply(double a, double b);

/// <summary>
/// 
/// </summary>
/// <param name="a">value of a</param>
/// <param name="b">value of b</param>
/// <returns>a / b</returns>
  double Divide(double a, double b);




}