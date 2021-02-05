using System;

namespace Conditions
{
    public class Program
    {
        public static double Max(double a, double b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
        public static double Min(double a, double b)
        {
            if (a <= b)
            {
                return a;
            }
            return b;
        }
        public static void WillSquareInRound(double a, double b)
        {
            double e = 0.0001;
            double r = Math.Sqrt((a / Math.PI));
            double s = Math.Sqrt(b);
            if (s - Math.Sqrt(2) * r <= e)
            {
                Console.WriteLine($"Поместится при площадях круга: {a} и квадрата: {b}");
                return;
            }
            Console.WriteLine($"Не, не поместится при площадях круга: {a} и квадрата: {b}");
        }
        public static double GetDouble(string word)
        {
            Console.Write("Введите {0} ", word);
            return double.Parse(Console.ReadLine());
        }
        public static int GetCount(string word)
        {
            return Convert.ToInt32(GetDouble(word));
        }
        static void Main(string[] args)
        {
            Lab3.Task9();
            Console.ReadKey();
        }
    }
}
