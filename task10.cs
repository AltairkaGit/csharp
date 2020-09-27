using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double result = 0;
      int a = 1;
      double b = 5;
      double factorial = 1;
      double max = 6;
      for (double i = 1; i <= max; i++)
      {
        a = -a;
        factorial *= i;
        double c = Math.Pow(b, i);
        result += (a * c / factorial);
      }
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}