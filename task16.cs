using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double start = 10000;
      double current = start;
      double percent = 0.08;
      int mounth;
      for (int i = 0; true; i++)
      {
        current *= (1 + percent);
        if (current >= (start * 2))
        {
          mounth = i;
          break;
        }
      }
      Console.WriteLine(mounth);
      Console.ReadKey();
    }
  }
}