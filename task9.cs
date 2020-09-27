using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      int result = 1;
      int factorial = 6;
      for (int i = 1; i <= factorial; i++)
      {
        result += result * i;
      }
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}