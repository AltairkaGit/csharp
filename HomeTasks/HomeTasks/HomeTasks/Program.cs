using System;

namespace HomeTasks
{
    class Program
    {
        static void Task1()
        {
            int s = 0;
            for (int i = 2; i <= 35; i += 3)
            {
                s += i;
            }
            Console.WriteLine(s);
        }
        static void Task2()
        {
            double s = 0;
            for (double i = 1; i <= 10; i++)
            {
                s += 1 / i;
            }
            Console.WriteLine(s);
        }
        static void Task3()
        {
            double s = 0;
            double a = 2;
            double b = 3;
            while (a <= 112)
            {
                s += a / b;
                a += 2;
                b += 2;
            }
            Console.WriteLine(s);
        }
        static void Task4()
        {
            double x = 2;
            double s = Math.Cos(x);
            double b = x;
            for (int a = 2; a < 10; a++)
            {
                s += Math.Cos(a * x) / b;
                b *= x;
            }
            Console.WriteLine(s);
        }
        static void Task5()
        {
            int s = 0;
            int p = 4;
            int h = 2;
            for (int i = 0; i < 10; i++)
            {
                s += (p + i * h) * (p + i * h);
            }
            Console.WriteLine(s);
        }
        static void Task6()
        {
            for (double x = -4; x <= 4; x += 0.5)
            {
                double result = 0.5 * x * x - 7 * x;
                Console.WriteLine($"{x, -5}   {result}");
            }
        }
        static void Task7()
        {
            int s = 1;
            for (int a = 2; a <= 6; a++)
            {
                s *= a;
            }
            Console.WriteLine(s);
        }
        static void Task8()
        {
            int s = 0;
            int fac = 1;
            for (int a = 2; a <= 7; a++)
            {
                s += fac;
                fac *= a;
            }
            Console.WriteLine(s);

        }
        static void Task9()
        {
            double s = 0;
            double b = -1;
            double c = 5;
            double fac = 1;
            for (double a = 2; a <= 7; a++)
            {
                s += b * c / fac;
                fac *= a;
                c *= 5;
                b = -b;
            }
            Console.WriteLine(s);

        }
        static void Task10()
        {
            int s = 3;
            for (int i = 1; i < 7; i++)
            {
                s *= 3;
            }
            Console.WriteLine(s);
        }
        static void Task11()
        {
            for (int a = 1; a <= 6; a++)
            {
                Console.Write($"{a} ");
            }
            Console.Write('\n');
            for (int a = 1; a <= 6; a++)
            {
                Console.Write("5 ");
            }
            Console.Write('\n');
        }
        static void Task12()
        {
            double s = 1;
            int x = 5;
            double b = x;
            for (double i = 1; i <= 10; i++)
            {
                s += 1 / b;
                b *= x;
            }
            Console.WriteLine(s);
        }
        static void Task13()
        {
            double x = -1.5;
            double h = 0.1;
            while (x <= -1)
            {
                Console.WriteLine($"{x, -26}  1");
                x += h;
            }
            while (x <= 1)
            {
                Console.WriteLine($"{x,-26}  {-x}");
                x += h;
            }
            while (x <= 1.5)
            {
                Console.WriteLine($"{x,-26}  -1");
                x += h;
            }
        }
        static void Task14()
        {
            int a = 1;
            int b = 1;
            int c;
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{a} ");
                c = a;
                a += b;
                b = c;
            }
            Console.WriteLine();
        }
        static void Task15()
        {
            double a = 1;
            double b = 1;
            double c;
            for (int i = 1; i < 5; i++)
            {
                c = a;
                a += b;
                b = c;
            }
            Console.WriteLine($"{a / b}");
        }
        static void Task16()
        {
            long s = 0;
            long c = 1;
            for (int i = 1; i < 64; i++)
            {
                s += c;
                c *= 2;
            }
            double g = s;
            Console.WriteLine($"{s} зёрен | {g / 15} грам");
        }
        static void Task17()
        {
            double r = 6350;
            for (double h = 1; h <= 10; h++)
            {
                double l = Math.Sqrt(h * (h + 2 * r));
                Console.WriteLine($"{h, -2}  {l}");
            }
        }
        static void Task18()
        {
            int x = 10;
            for (int h = 3; h <= 24; h += 3)
            {
                Console.WriteLine($"{h, -2}  {x}");
                x *= 2;
            }
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
            Console.WriteLine("\nTask 8");
            Program.Task8();
            Console.WriteLine("\nTask 9");
            Program.Task9();
            Console.WriteLine("\nTask 10");
            Program.Task10();
            Console.WriteLine("\nTask 11");
            Program.Task11();
            Console.WriteLine("\nTask 12");
            Program.Task12();
            Console.WriteLine("\nTask 13");
            Program.Task13();
            Console.WriteLine("\nTask 14");
            Program.Task14();
            Console.WriteLine("\nTask 15");
            Program.Task15();
            Console.WriteLine("\nTask 16");
            Program.Task16();
            Console.WriteLine("\nTask 17");
            Program.Task17();
            Console.WriteLine("\nTask 18");
            Program.Task18();
            Console.ReadKey();
        }
    }
}
