using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double e = 0.0001;
      double result, sub;
      int a = -1;
      for (double i = 0.1; i <= 1; i += 0.1)
      {
        double similiar = Math.Cos(i);
        for (int j = 0; true; i++)
        {
          double pre = Math.Pow(a, j);
          double top = Math.Pow(i, 2 * j);
          double fact = 1;
          for (int k = 1; k <= 2 * j; j++)
          {
            fact *= k;
          }
          double arg = pre * top / fact;
          if (arg < e)
          {
            break;
          }
          sub += arg;
        }
        result += sub;
        Console.WriteLine($"a result {sub} must be similiar to {similiar}");
        sub = 0;
      }
      Console.WriteLine(result);
      Console.ReadKey();
    }
  }
} 