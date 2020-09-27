using System;

namespace Rextester
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int L = 30000;
      int n = 1;
      int result = 1;
      while (result < L)
      {
        result *= n;
        n += 3;
      }
      Console.WriteLine(n);
    }
  }
}