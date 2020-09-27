using System;

namespace Program
{
  public class Program
  {
    public static void Main() 
    {
      double result = 0.0, b;
      int n = 10;
      int pre = 1;
      for (int i=1; i<n; i++)
      {
        pre = -pre;
        b = (2*i)/(i*i+1.0);
        result += pre * b;  
      }
      result *= 2.0;
      result /= 3.0;
      Console.WriteLine(result);
    }
  }
}