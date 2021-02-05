using System;

namespace Methods
{
    class Program
    {
        public static double GetDouble(string word = "число")
        {
            Console.WriteLine($"Введите {word}: ");
            return Double.Parse(Console.ReadLine().Trim());
        }
        public static int GetInt(string word)
        {
            return Convert.ToInt32(GetDouble(word));
        }
        public static double[] GetDoubleArr(string word)
        {
            Console.WriteLine("Вводить через пробел");
            string[] arr = Console.ReadLine().Split(" ");
            double[] result = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = Double.Parse(arr[i].Trim());
            }
            return result;
        }
        public static int[] GetIntArr(string word)
        {
            Console.WriteLine("Вводить через пробел");
            string[] arr = Console.ReadLine().Split(" ");
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = Convert.ToInt32(arr[i].Trim());
            }
            return result;
        }
        public static void CheckSameLen<T, U>(T[] args, U[] res)
        {
            if (args.Length != res.Length)
            {
                Console.WriteLine("Аргументы и Значения в неравном количестве");
                throw new Exception("Аргументы и Значения в неравном количестве");
            }
        }
        public static void PrintTable<T, U>(T[] args, U[] res)
        {
            CheckSameLen(args, res);
            int l = args.Length;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine($"{args[i]}   {res[i]}");
            }
        }
        public static Factorial<T>(T n)
        public static int CalculateTeam(int team, int all) 
        {
            int
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
