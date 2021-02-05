using System;
using System.Runtime.InteropServices;

namespace Arrays
{
    class Program
    {
        public static double[] GetArr()
        {
            int length = Convert.ToInt32(Program.GetCount("длинну массива"));
            double[] arr = new double[length];
            for (int i = 0; i < length; i++)
            {
                double c = GetCount(Convert.ToString(i + 1));
                arr[i] = c;
            }
            return arr;
        }
        public static double[] GetHalfArr()
        {
            int length = Convert.ToInt32(Program.GetCount("длинну массива"));
            double[] arr = new double[length];
            length = length % 2 == 0 ? length / 2 : length / 2 + 1;
            for (int i = 0; i < length; i++)
            {
                double c = GetCount(Convert.ToString(i + 1));
                arr[i] = c;
            }
            return arr;
        }
        public static double GetCount(string word)
        {
            Console.Write($"Введите {word}: ");
            double a = Double.Parse(Console.ReadLine().Trim());
            return a;
        }
        public static void PrintArr(dynamic arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                double c = arr[i];
                if (c%1 != 0)
                {
                    Console.Write($"{arr[i]:f2}  ");
                }
                else
                {
                    Console.Write($"{arr[i]}  ");
                }                
            }
            Console.WriteLine();
        }
        /*
        public static int GetMinIdx(dynamic arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            int minIdx = start;
            double min = arr[start];
            for (int i = start; i < end; i++)
            {
                if (arr[i] < min)
                {
                    minIdx = i;
                    min = arr[i];
                }
            }
            return minIdx;
        }
        public static int GetMaxIdx(dynamic arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            int maxIdx = start;
            double max = arr[start];
            for (int i = start; i < end; i++)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            return (maxIdx);
        }
        public static (int, int) GetMinMaxIdx(dynamic arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            int minIdx = start;
            double min = arr[start];
            int maxIdx = start;
            double max = arr[start];
            for (int i = start; i < end; i++)
            {
                if (arr[i] < min)
                {
                    minIdx = i;
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            return (minIdx, maxIdx);
        }
        */
        public static double GetArrSum(dynamic arr, int start = 0, int end = -1, int step = 1)
        {
            if (end == -1) end = arr.Length; 
            double sum = 0;
            for (int i = start; i < end; i += step)
            {
                sum += arr[i];
            }
            return sum;
        }
        /*
        public static double GetArrMiddle(dynamic arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            return middle;
        }
        
        public static int[] GetArrMaxes(double[] arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            int l = 0;
            double max = arr[0];
            for (int i = 0; i < end; i++)
            {
                if (arr[i] == max)
                {
                    l++;
                }
                if (arr[i] > max)
                {
                    l = 0;
                    max = arr[i];
                    l++;
                }
            }
            int[] res = new int[l];
            for (int i = 0, j = 0; i < end; i++)
            {
                if (arr[i] == max)
                {
                    res[j] = i;
                    j++;
                }
            }
            return res;
        }        
        public static void BubbleSort(ref double[] arr, bool incrace = true)
        {
            int k = arr.Length;
            bool replace;
            for (int i = 0; i < k - 1; i++)
            {
                replace = false;
                for (int j = 0; j < k - i - 1; j++)
                {
                    if (incrace && arr[j + 1] < arr[j])
                    {
                        double c = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = c;
                        replace = true;
                    }
                    if (!incrace && arr[j + 1] > arr[j])
                    {
                        double c = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = c;
                        replace = true;
                    }
                }
                if (replace == false) break;
            }
        }
        */
        static void Main(string[] args)
        {
            Lab3.Task7();
            Console.ReadKey();
        }
    }
}
