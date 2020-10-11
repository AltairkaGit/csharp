using System;

namespace HomeTasks3
{
    class Program
    {
        static int Fact(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }
        static void Task1()
        {
            double e = 0.0001;
            double s = 0;
            double r = 0;
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                double c;
                int a = 1;
                int i = 0;
                do
                {

                    c = a * Math.Pow(x, 2 * i) / Program.Fact(2 * i);
                    s += c;
                    a = -a;
                    i++;
                }
                while (Math.Abs(c) > e);
                r += Math.Cos(x);
            }
            Console.WriteLine($"{s}  {r}");
        }
        static void Task7()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Program.Task1();
            
        }
    }
}
