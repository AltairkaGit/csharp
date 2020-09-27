using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double result = 1;
      int x = 10;
      for (int i = 0; i <= 10; i++)
      {
        result += (1 / Math.Pow(x, i));
      }
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}