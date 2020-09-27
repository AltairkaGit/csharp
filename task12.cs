using System;

namespace Rextester
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int result = 3;
      for (int i = 1; i < 7; i++)
      {
        result *= 3;
      }
      Console.WriteLine(result);
    }
  }
}