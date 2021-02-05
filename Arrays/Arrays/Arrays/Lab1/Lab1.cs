using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Lab1
    {
        public static void Task1()
        {
            double[] arr = new double[6] { 1, 2, 3, 4, 5, 6 };
            double result = Program.GetArrSum(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= result;
            }
            Program.PrintArr(arr);
        }
        public static void Task2()
        {
            double positives = 0;
            double positivesSum = 0;
            double middle;
            double[] arr = new double[8] { -1, 2, -3, 4, -5, 6, -7, 8 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positives++;
                    positivesSum += arr[i];
                }
            }
            middle = positivesSum / positives;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] = middle;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task3()
        {
            int[] a = new int[4] { 101, 303, 505, 707 };
            int[] b = new int[4] { 202, 404, 606, 808 };
            int[] s = new int[4];
            int[] d = new int[4];
            for (int i = 0; i < a.Length; i++)
            {
                s[i] = a[i] + b[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                d[i] = b[i] - a[i];
            }
            Program.PrintArr(s);
            Console.WriteLine();
            Program.PrintArr(d);
        }
        public static void Task4()
        {
            double[] arr = new double[5] { 101, 303, 505, 707, 909 };
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= middle;
            }
            Program.PrintArr(arr);
        }
        public static void Task5()
        {
            int[] a = new int[4] { 1, 1, 1, 1 };
            int[] b = new int[4] { 2, 2, 2, 2 };
            int r = 0;
            for (int i = 0; i < a.Length; i++)
            {
                r += a[i] * b[i];
            }
            Console.Write(r);
        }
        public static void Task6()
        {
            int[] vector = new int[5] { 1, 5, 16, 21, 73 };
            int s = 0;
            double r;
            for (int i = 0; i < vector.Length; i++)
            {
                int a = vector[i];
                s += a * a;
            }
            r = Math.Sqrt(s);
            Console.WriteLine(r);
        }
        public static void Task7()
        {
            double[] arr = new double[7] { 1, 5, 16, 21, 73, 101, 237 };
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > middle)
                {
                    arr[i] = 0;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task8()
        {
            double[] arr = new double[6] { -5, 16, -21, 73, 101, 237 };
            int negatives = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negatives++;
                }
            }
            Console.Write(negatives);
        }
        public static void Task9()
        {
            double[] arr = new double[8] { 1, -5, 16, -21, 73, 101, 237, 543 };
            int s = 0;
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > middle)
                {
                    s++;
                }
            }
            Console.Write(s);
        }
        public static void Task10()
        {
            int s = 0;
            double[] arr = new double[10] { 1, -5, 16, -21, 73, 101, 237, 543, 721, 944 };
            double p = Program.GetCount("P");
            double q = Program.GetCount("Q, Q > P");
            while (p > q)
            {
                q = Program.GetCount("Q, Q > P");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                double c = arr[i];
                if (c > p & c < q)
                {
                    s++;
                }
            }
            Console.WriteLine(s);
        }
        public static void Task11()
        {
            int l = (int)Math.Round(Program.GetCount("длинну массива"));
            double[] arr = new double[l];
            int positives = 0;
            for (int i = 0; i < l; i++)
            {
                arr[i] = Program.GetCount($"{i + 1} элемент массива");
            }
            for (int i = 0; i < l; i++)
            {
                if (arr[i] > 0) positives++;
            }
            double[] s = new double[positives];
            positives = 0;
            for (int i = 0; i < l; i++)
            {
                if (arr[i] > 0)
                {
                    s[positives] = arr[i];
                    positives++;
                }
            }
            Program.PrintArr(s);
        }
        public static void Task12()
        {
            double[] arr = new double[8] { 1, -5, 16, -21, 73, 101, -237, 543 };
            double val = 0;
            double idx = 0;
            double c;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                c = arr[i];
                if (c < 0)
                {
                    val = c;
                    idx = i;
                    break;
                }
            }
            Console.WriteLine($"{idx + 1}  {val}");
        }
        public static void Task13()
        {
            double[] arr = new double[10] { 1, -5, 16, -21, 73, 101, -237, 543, -432, 1111 };
            int c = 0;
            int d = 0;
            double[] a = new double[5];
            double[] b = new double[5];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a[c] = arr[i];
                    c++;
                }
                else
                {
                    b[d] = arr[i];
                    d++;
                }
            }
            Program.PrintArr(a);
            Console.WriteLine();
            Program.PrintArr(b);
        }
        public static void Task14()
        {
            double[] arr = new double[11] { 0, 1, 5, 16, -21, 73, 101, -237, 543, -432, 1111 };
            double s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) break;
                s += arr[i] * arr[i];
            }
            Console.WriteLine(s);
        }
        public static void Task15()
        {
            double[] x = new double[10] { 0, 1, 5, 16, -21, 73, 101, -237, 543, -432 };
            double[] y = new double[10];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = 0.5 * Math.Log(x[i]);
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i],4}    {y[i],4}");
            }
        }
    }
}
