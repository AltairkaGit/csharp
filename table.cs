using System;

namespace Program
{
  public class Program
  {
    public static double Calc(double x)
    {
      return x*x + 0.5*x;
    }
    public static void Main(String[] args)
    {
      double start = -2.5, end = 2.5;
      for (double i = start; i <= end; i += 0.5)
      {
        double value = Program.Calc(i);
        Console.WriteLine(String.Format("Argument: {0, -4}    Value: {1}", i, value));
      }
      Console.ReadKey();
    }
  }
}