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
            double e = 0.0001;
            double s = 0;
            double r = 0;
            for (double x = 0.1; x <= 1; x += 0.05)
            {
                double c;
                int i = 0;
                do
                {

                    c = Math.Pow(x, 2 * i) / Program.Fact(2 * i);
                    s += c;
                    i++;
                } while (Math.Abs(c) > e);
                r += (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
            }
            Console.WriteLine($"{s}  {r}");
        }
        static void Task8()
        {
            double e = 0.0001;
            double s = 0;
            double r = 0;
            for (double x = 0.1; x <= 1; x += 0.05)
            {
                double c;
                int i = 0;
                do
                {
                    c = Math.Pow(2 * x, i) / Program.Fact(i);
                    s += c;
                    i++;
                } while (Math.Abs(c) > e);
                r += Math.Pow(Math.E, 2 * x);
            }
            Console.WriteLine($"{s}  {r}");
        }
        static void Task9()
        {
            double e = 0.0001;
            double s = 0;
            double r = 0;
            for (double x = 0.1; x <= 0.5; x += 0.05)
            {
                int a = 1;
                double c;
                int i = 0;
                do
                {
                    double k = 2 * i + 1;
                    c = a * Math.Pow(x, k) / k;
                    s += c;
                    a = -a;
                    i++;
                } while (Math.Abs(c) > e);
                r += Math.Atan(x);
            }
            Console.WriteLine($"{s}  {r}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Program.Task1();
            Console.WriteLine("Task 7");
            Program.Task7();
            Console.WriteLine("Task 8");
            Program.Task8();
            Console.WriteLine("Task 9");
            Program.Task9();

        }
    }
}
