using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double result = 1;
      double x = 0.1;
      double e = 0.0001;
      for (int i = 0; true; i++)
      {
        double arg = Math.Pow(x, 2*i);
        if (arg < e)
        {
          break;
        }
        result += arg;
      }
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
}