using System;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      double start = 10;
      double seven_day = 0;
      double hundred = 0;
      double twenty = 0;
      double percent = 0.07;
      for (int i = 0; i < 7; i++)
      {
        seven_day += start;
        start *= (1 + percent);
      }
      start = 10;
      for (int i = 0; true; i++)
      {
        hundred += start;
        start *= (1 + percent);
        if (hundred >= 100)
        {
          hundred = i;
          break;
        }
      }
      start = 10;
      for (int i = 0; true; i++)
      {
        twenty += start;
        start *= (1 + percent);
        if (start >= 20)
        {
          twenty = i;
          break;
        }
      }
      Console.WriteLine($"sum 7 days way: {seven_day} | day when 100km: {hundred} | day when 20km per day {twenty}");
      Console.ReadKey();
    }
  }
}