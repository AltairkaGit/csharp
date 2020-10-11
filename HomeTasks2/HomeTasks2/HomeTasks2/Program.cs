using System;

namespace HomeTasks2
{
    class Program
    {
        static void Task1()
        {
            double s = 0;
            double e = 0.0001;
            double x = 4;
            double c;
            int i = 1;
            do
            {
                c = Math.Cos(i * x) / (i * i);
                s += c;
                i++;
            } while (Math.Abs(c) > e);
            Console.WriteLine(s);
        }
        static void Task2()
        {
            int i = 1;
            int s = 1;
            while (s < 30000)
            {
                i += 3;
                s *= i;
            }
            Console.WriteLine(i);
        }
        static void Task3()
        {
            int i = 0;
            int s = 0;
            int a = 5;
            int h = 3;
            int p = 400;
            while (s < p)
            {
                s += a + i * h;
                i++;
            }
            i++;
            Console.WriteLine(i);
        }
        static void Task4()
        {
            double s = 1;
            double x = 0.5;
            double e = 0.0001;
            double a = x * x;
            while (a > e)
            {
                s += a;
                a *= x * x;
            }
            Console.WriteLine(s);
        }
        static void Task5()
        {
            double m = 5;
            double n = 2;
            double c = m;
            double i = 0;
            //c - остаток
            //о - частное
            while (c > n)
            {
                c -= n;
                i++;
            }
            double o = i + c / n;
            Console.WriteLine($"{c,-2}  {o}");

        }
        static void Task6()
        {
            int x = 10;
            int h = 3;
            while (x < 100000)
            {
                h += 3;
                x *= 2;
            }
            Console.WriteLine($"через {h} часов будет {x} амёб");
        }
        static void Task7()
        {
            double start = 10;
            double seven_day = 0;
            double hundred = 0;
            double twenty = 0;
            double percent = 0.07;
            int i = 0;
            for (int a = 0; a < 7; a++)
            {
                seven_day += start;
                start *= (1 + percent);
            }
            start = 10;
            while (hundred < 100)
            {
                hundred += start;
                start *= (1 + percent);
                i++;
            }
            hundred = i;
            i = 0;
            start = 10;
            while (start < 20)
            {
                twenty += start;
                start *= (1 + percent);
                i++;
            }
            twenty = i;
            Console.WriteLine($"sum 7 days way: {seven_day} | day when 100km: {hundred} | day when 20km per day {twenty}");
        }
        static void Task9()
        {
            double start = 10000;
            double current = start;
            double percent = 0.08;
            int i = 0;
            while (current < (start * 2))
            {
                current *= (1 + percent);
                i++;
            }
            Console.WriteLine(i);
        }
        static void Task10()
        {
            double l = 0.1;
            double a = Math.Pow(10, -10);
            int i = 0;
            while (l > a)
            {
                l /= 2;
                i++;
            }
            Console.WriteLine(i);

        }
        static void Task11()
        {
            //а - числитель
            //b - знаменатель
            double a = 1;
            double b = 1;
            double c;
            double m, n;
            do
            {
                m = a / b;
                c = a;
                a += b;
                b = c;
                n = a / b;
            } while (Math.Abs(n - m) > 0.001);
            Console.WriteLine($"{n}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Program.Task1();
            Console.WriteLine("\nTask 2");
            Program.Task2();
            Console.WriteLine("\nTask 3");
            Program.Task3();
            Console.WriteLine("\nTask 4");
            Program.Task4();
            Console.WriteLine("\nTask 5");
            Program.Task5();
            Console.WriteLine("\nTask 6");
            Program.Task6();
            Console.WriteLine("\nTask 7");
            Program.Task7();
            Console.WriteLine("\nTask 9");
            Program.Task9();
            Console.WriteLine("\nTask 10");
            Program.Task10();
            Console.WriteLine("\nTask 11");
            Program.Task11();
            Console.ReadKey();
        }
    }
}
