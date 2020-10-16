using System;

namespace Conditionals2
{
    class Program
    {
        static void Task1()
        {
            Console.Write("сколько в кдассе учеников: ");
            int n = Int32.Parse(Console.ReadLine());
            int h = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Рост очередного ученика: ");
                h += Int32.Parse(Console.ReadLine());
            }
            double middle = (double)h / (double)n;
            Console.WriteLine(middle);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Program.Task1();
        }
    }
}
