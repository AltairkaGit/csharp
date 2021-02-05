using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    public class Lab1
    {
        public static void Task1()
        {
            Console.Write("Введите х: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Double.Parse(Console.ReadLine());
            double e = 0.001;
            double r = 2;
            if (Math.Abs(x * x + y * y - r * r) <= e)
            {
                Console.WriteLine("Лежит");
                return;
            }
            Console.WriteLine("Не, не лежит");
        }
        public static void Task2()
        {
            Console.Write("Введите х: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Double.Parse(Console.ReadLine());
            if (y >= 0 && y + Math.Abs(x) <= 1)
            {
                Console.WriteLine("Лежит");
                return;
            }
            Console.WriteLine("Не, не лежит");
        }
        public static void Task3()
        {
            double c;
            Console.Write("Введите a: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Double.Parse(Console.ReadLine());
            if (a > 0)
            {

                c = Program.Max(a, b);
                Console.WriteLine(c);
                return;
            }
            c = Program.Min(a, b);
            Console.WriteLine(c);
        }
        public static void Task4()
        {
            Console.Write("Введите a: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Double.Parse(Console.ReadLine());
            Console.WriteLine(Program.Max(Program.Min(a, b), c));
        }
        public static void Task5()
        {
            double a, b;
            a = 70;
            b = 36.74;
            Program.WillSquareInRound(a, b);
            a = 0.86;
            b = 0.74;
            Program.WillSquareInRound(a, b);
        }
        public static void Task6()
        {
            double a, b;
            a = 3.2;
            b = 3.5;
            Program.WillSquareInRound(a, b);
            a = 3.2;
            b = 4;
            Program.WillSquareInRound(a, b);
            a = 6;
            b = 9;
            Program.WillSquareInRound(a, b);
        }
        public static void Task7()
        {
            Console.Write("Введите x: ");
            double x = Double.Parse(Console.ReadLine());
            double absX = Math.Abs(x);
            double y;
            if (absX > 1)
            {
                y = 1;
            }
            else
            {
                y = absX;
            }
            Console.WriteLine(y);
        }
        public static void Task8()
        {
            Console.Write("Введите x: ");
            double x = Double.Parse(Console.ReadLine());
            double absX = Math.Abs(x);
            double y;
            if (absX >= 1)
            {
                y = 0;
            }
            else
            {
                y = x * x - 1;
            }
            Console.WriteLine(y);
        }
        public static void Task9()
        {
            Console.Write("Введите x: ");
            double x = Double.Parse(Console.ReadLine());
            double y;
            if (x <= -1)
            {
                y = 0;
            }
            else if (x > -1 && x <= 0)
            {
                y = x + 1;
            }
            else
            {
                y = 1;
            }
            Console.WriteLine(y);
        }
        public static void Task10()
        {
            Console.Write("Введите x: ");
            double x = Double.Parse(Console.ReadLine());
            double y;
            if (x <= -1)
            {
                y = 1;
            }
            else if (x > -1 && x <= 1)
            {
                y = -x;
            }
            else
            {
                y = -1;
            }
            Console.WriteLine(y);
        }
    }
}
