using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Lab3
    {
        public static void Task1()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            double max = arr[0];
            double[] maxs = new double[arr.Length];
            for (int j = 0; j < maxs.Length; j++)
            {
                maxs[j] = -1;
            }
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    maxs[j] = i;
                    j++;
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    i = 0;
                    j = 0;
                } 
                else
                {
                    maxs[i] = -1;
                }
            }            
            Program.PrintArr(maxs);
        }
        public static void Task2()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            for (int i = 0, j = 1; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    arr[i] += j;
                    j++;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task3()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            double c;
            for (int i = 0; i < maxIdx; i += 2)
            {
                if (i + 1 == maxIdx)
                {
                    continue;
                }
                c = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = c;
            }
            Program.PrintArr(arr);
        }
        public static void Task4()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int l = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
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
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    res[j] = i;
                    j++;
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                int idx = res[i];
                double sum = Program.GetArrSum(arr, 0, idx + 1);
                arr[idx] = sum;
            }
            Program.PrintArr(arr);
        }
        public static void Task5()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int l = 0;
            for (int i = 0; i < arr.Length; i += 2) l++;
            double[] even = new double[l];
            for (int i = 0, j = 0; i < arr.Length; i += 2)
            {
                even[j] = arr[i];
                j++;
            }
            int k = even.Length;
            bool replace;
            for (int i = 0; i < k - 1; i++)
            {
                replace = false;
                for (int j = 0; j < k - i - 1; j++)
                {
                    if (even[j + 1] < even[j])
                    {
                        double c = even[j];
                        even[j] = even[j + 1];
                        even[j + 1] = c;
                        replace = true;
                    }                    
                }
                if (replace == false) break;
            }
            for (int i = 0, j = 0; i < arr.Length; i += 2)
            {
                arr[i] = even[j];
                j++;
            }
            Program.PrintArr(arr);
        }
        public static void Task6()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int n = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    n++;
                }
                else
                {
                    n = 0;
                }
            }
            Console.WriteLine(n);
        }
        public static void Task7()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            for (int i = 0, l = 0; i < arr.Length - l; i++)
            {
                if (arr[i] < 0)
                {
                    double c = arr[i];
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[arr.Length - 1] = c;
                    l++;
                    i--;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task8()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    l++;
                }
            }
            double[] neg = new double[l];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    neg[j] = arr[i];
                    j++;
                }                
            }
            int k = neg.Length;
            bool replace;
            for (int i = 0; i < k - 1; i++)
            {
                replace = false;
                for (int j = 0; j < k - i - 1; j++)
                {                  
                    if (neg[j + 1] > neg[j])
                    {
                        double c = arr[j];
                        neg[j] = neg[j + 1];
                        neg[j + 1] = c;
                        replace = true;
                    }
                }
                if (replace == false) break;
            }
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = neg[j];
                    j++;
                }                
            }
            Program.PrintArr(arr);
        }
        public static void Task9()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int inc = 0;
            int dec = 0;
            int a = 0;
            int b = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] > arr[i])
                {
                    a++;
                }
                else
                {
                    b++;
                }
                if (i > 0 && arr[i] > arr[i - 1] && arr[i + 1] < arr[i])
                {
                    inc = a;
                    a = 0;
                }
                if (i > 0 && arr[i] < arr[i - 1] && arr[i + 1] > arr[i])
                {
                    dec = b;
                    b = 0;
                }
            }
            inc = a;
            dec = b;
            Console.WriteLine(inc > dec ? $"возрастающая {inc}" : $"убывающая {dec}");
        }
        public static void Task10()
        {
            double[] arr = Program.GetHalfArr();
            Program.PrintArr(arr);
            for (int i = 1; i < arr.Length; i += 2)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[i] = arr[i - 1];
            }
            Program.PrintArr(arr);
        }
        public static void Task11()
        {
            double a = Program.GetCount("A");
            double b = Program.GetCount("B");
            while (b < a) b = Program.GetCount("B");
            int n = (int)Program.GetCount("сколько точек");
            double step = (b - a) / n;
            double[] x = new double[n];
            x[0] = a;
            double[] y = new double[n];
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + step; 
            }
            for (int i = 0; i < n; i++)
            {
                y[i] = Math.Cos(x[i]) + x[i] * Math.Sin(x[i]);
            }
            int gMax = 0;
            double max = y[0];
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] > max)
                {
                    gMax = i;
                    max = y[i];
                }
            }
            int gMin = 0;
            double min = y[0];
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] < min)
                {
                    gMin = i;
                    min = y[i];
                }
            }
            int lMaxl = 0;
            for (int i = 1; i < y.Length - 1; i++)
            {
                if (y[i] > y[i - 1] && y[i] > y[i + 1]) lMaxl++;
            }
            int[] lMax = new int[lMaxl];
            for (int i = 1; i < lMax.Length - 1; i++)
            {
                if (y[i] > y[i - 1] && y[i] > y[i + 1])
                {
                    lMax[i] = i;
                }
            }
            int lMinl = 0;
            for (int i = 1; i < y.Length - 1; i++)
            {
                if (y[i] < y[i - 1] && y[i] < y[i + 1]) lMinl++;
            }
            int[] lMin = new int[lMinl];
            for (int i = 1; i < lMin.Length - 1; i++)
            {
                if (y[i] < y[i - 1] && y[i] < y[i + 1])
                {
                    lMin[i] = i;
                }
            }
            //Print
            Console.WriteLine($"Глобальный максимум: {x[gMax]} {y[gMax]}");
            Console.WriteLine($"Глобальный минимум: {x[gMin]} {y[gMin]}");
            Console.WriteLine();
            for (int i = 0; i < lMax.Length; i++)
            {
                Console.WriteLine($"Локальный максимум: {x[lMax[i]]} {y[lMax[i]]}");
            }
            Console.WriteLine();
            for (int i = 0; i < lMin.Length; i++)
            {
                Console.WriteLine($"Локальный минимум: {x[lMin[i]]} {y[lMin[i]]}");
            }
        }
        public static void Task12()
        {
            //Создаем рандомный массив длиной 12
            double[] arr = new double[12];
            double c;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-2, 5);
            }
            Program.PrintArr(arr);
            //Заменяем все отрицательные элементы отрицательными по убыванию 
            int j = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = j;
                    j--;
                }
            }
            Program.PrintArr(arr);
            //Теперь каждое отрицательное по порядку тащим в конец
            for (int k = 0; k < -j; k++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] == -k - 1)
                    {
                        c = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = c;
                    }
                }
            }
            Program.PrintArr(arr);
            //И заменяем нулями т.к. считаем, что нули в конце массива - удаленные элементы
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task13()
        {
            //Создаем массив
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            if (arr.Length == 0) return;
            /* 
            Создаем т = 1 элемент
            со 2 элемента массива будем сравниать с т
            если равно, то как в предыдущем 
            заменяем на отрицательные по порядку
            если нет, значит элемент поменялся и 
            мы заменяем т этим элементом, 
            который может повторяться

            12121
             */
            double t = arr[0];
            double j = -1;
            double c;
            bool repeated;
            for (int i = 1; i < arr.Length; i++)
            {
                repeated = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        repeated = true;
                    }
                }
                if (repeated)
                {
                    arr[i] = j;
                    j--;
                }                
            }
            Program.PrintArr(arr);
            //Теперь каждое отрицательное по порядку тащим в конец
            for (int k = 0; k < -j; k++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] == -k - 1)
                    {
                        c = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = c;
                    }
                }
            }
            Program.PrintArr(arr);
            //И заменяем нулями т.к. считаем, что нули в конце массива - удаленные элементы
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task14()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int k = arr.Length;
            bool replace;
            for (int i = 0; i < k - 1; i++)
            {
                replace = false;
                for (int j = 0; j < k - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        double c = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = c;
                        replace = true;
                    }
                }
                if (replace == false) break;
            }
            int minIdx = 0;
            double min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    minIdx = i;
                    min = arr[i];
                }
            }
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            double mid = middle;
            double[] res = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                double c = arr[i];
                if (c >= mid)
                {
                    res[i] = Math.Abs((c - mid) / (max - mid));
                }
                else
                {
                    res[i] = -1 * Math.Abs((mid - c) / (mid - min));
                }
            }
            Program.PrintArr(res);
        }
    }
}
