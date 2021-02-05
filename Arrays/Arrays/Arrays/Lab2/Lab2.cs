using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Lab2
    {
        public static void Task1()
        {
            double[] arr = Program.GetArr();
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
            Program.PrintArr(arr);
            arr[minIdx] *= 2;
            Program.PrintArr(arr);
        }
        public static void Task2()
        {
            double[] arr = Program.GetArr();
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
            double s = Program.GetArrSum(arr, 0, maxIdx + 1);
            Console.WriteLine(s);
        }
        public static void Task3()
        {
            double[] arr = Program.GetArr();
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
            Program.PrintArr(arr);
            for (int i = 0; i < minIdx; i++)
            {
                arr[i] *= 2;
            }
            Program.PrintArr(arr);
        }
        public static void Task4()
        {
            double[] arr = Program.GetArr();
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
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
            Program.PrintArr(arr);
            for (int i = maxIdx + 1; i < arr.Length; i++)
            {
                arr[i] = middle;
            }
            Program.PrintArr(arr);
        }
        public static void Task5()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int l = 0;
            int j = 0;
            int minIdx = 0;
            double min = arr[0];
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
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
            if (maxIdx > minIdx)
            {
                for (int i = minIdx + 1; i < maxIdx; i++)
                {
                    if (arr[i] < 0)
                    {
                        l++;
                    }
                }
                double[] negatives = new double[l];
                for (int i = minIdx + 1; i < maxIdx; i++)
                {
                    if (arr[i] < 0)
                    {
                        negatives[j] = arr[i];
                        j++;
                    }
                }
                Program.PrintArr(negatives);
            }
            else
            {
                for (int i = maxIdx + 1; i < minIdx; i++)
                {
                    if (arr[i] < 0)
                    {
                        l++;
                    }
                }
                double[] negatives = new double[l];
                for (int i = maxIdx + 1; i < minIdx; i++)
                {
                    if (arr[i] < 0)
                    {
                        negatives[j] = arr[i];
                        j++;
                    }
                }
                Program.PrintArr(negatives);
            }
            
        }
        public static void Task6()
        {
            int length = Convert.ToInt32(Program.GetCount("длинну массива"));
            double[] arr = new double[length];
            for (int i = 0; i < length - 1; i++)
            {
                double c = Program.GetCount(Convert.ToString(i + 1));
                arr[i] = c;
            }
            Program.PrintArr(arr);
            int end = arr.Length - 1, start = 0;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            Console.WriteLine(middle);
            double p = Program.GetCount("P");
            double dif = Math.Abs(arr[0] - middle);
            int idx = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                double d = Math.Abs(arr[i] - middle);
                if (d <= dif)
                {
                    idx = i;
                    dif = d;
                }
            }
            Console.WriteLine(middle);
            for (int i = arr.Length - 1, j = arr.Length - 2; i >= 0; i--)
            {
                if (i == idx + 1)
                {
                    break;
                }
                arr[i] = arr[j];
                j--;
            }
            arr[idx + 1] = p;
            Program.PrintArr(arr);
        }
        public static void Task7()
        {
            double[] arr = Program.GetArr();
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
            Program.PrintArr(arr);
            if (maxIdx + 1 < arr.Length) arr[maxIdx + 1] *= 2;
            Program.PrintArr(arr);
        }
        public static void Task8()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            int minIdx = maxIdx + 1;
            if (minIdx >= arr.Length)
            {
                Program.PrintArr(arr);
                return;
            }
            double min = arr[minIdx];
            for (int i = minIdx; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    minIdx = i;
                    min = arr[i];
                }
            }            
            double c = arr[minIdx];
            arr[minIdx] = arr[maxIdx];
            arr[maxIdx] = c;            
            Program.PrintArr(arr);
        }
        public static void Task9()
        {
            double[] arr = Program.GetArr();
            int minIdx = 0;
            double min = arr[0];
            int maxIdx = 0;
            double max = arr[0];
            for (int i = 0; i < arr.Length; i++)
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
            int l = 0;
            double middle;
            double sum = 0;
            if (maxIdx > minIdx)
            {
                for (int i = minIdx + 1; i < maxIdx; i++)
                {
                    sum += arr[i];
                    l++;
                }                
            }
            else
            {
                for (int i = maxIdx + 1; i < minIdx; i++)
                {
                    sum += arr[i];
                    l++;
                }               
            }
            middle = sum / l;
            Console.WriteLine(middle);
        }
        //here
        public static void Task10()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            double[] res = new double[arr.Length - 1];
            int minIdx = 0;
            double min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    minIdx = i;
                    min = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 &&  arr[i] < min)
                {
                    minIdx = i;
                    min = arr[i];
                }
            }
            for (int i = 0, j = 0; i < res.Length; i++)
            {
                if (i == minIdx) j++;
                res[i] = arr[j];
                j++;
            }            
            Program.PrintArr(res);
        }
        public static void Task11()
        {
            //Спросили длину, создали массив
            int length = Convert.ToInt32(Program.GetCount("длинну массива"));
            double[] arr = new double[length];
            for (int i = 0; i < length - 1; i++)
            {
                double c = Program.GetCount(Convert.ToString(i + 1));
                arr[i] = c;
            }
            Program.PrintArr(arr);
            double p = Program.GetCount("P");
            //Находим последний положительный элемент перебором с конца
            int idx = arr.Length - 2;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] > 0)
                {
                    idx = i;
                    break;
                }
            }
            for (int i = arr.Length - 1, j = arr.Length - 2; i >= 0; i--)
            {
                if (i == idx + 1)
                {
                    break;
                }
                arr[i] = arr[j];
                j--;

            }
            arr[idx + 1] = p;
            Program.PrintArr(arr);
        }
        public static void Task12()
        {
            double[] arr = Program.GetArr();
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
            double sum = Program.GetArrSum(arr, maxIdx + 1);
            int idx = arr.Length - 1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    idx = i;
                    break;
                }
            }
            Program.PrintArr(arr);
            arr[idx] = sum;
            Program.PrintArr(arr);
        }
        public static void Task13()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            double max = arr[0];
            int maxIdx = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr[i] > max)
                {
                    maxIdx = i;
                    max = arr[i];
                }
            }
            arr[maxIdx] = maxIdx;
            Program.PrintArr(arr);
        }
        public static void Task14()
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
            int negativeIdx = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeIdx = i;
                    break;
                }
            }
            if (negativeIdx == -1) negativeIdx = maxIdx;
            double negative = arr[negativeIdx];
            arr[negativeIdx] = max;
            arr[maxIdx] = negative;
            Program.PrintArr(arr);
        }
        public static void Task15()
        {
            int lA = Convert.ToInt32(Program.GetCount("длинну массива A"));
            int lB = Convert.ToInt32(Program.GetCount("длинну массива B"));
            while (lB > lA)
            {
                lB = Convert.ToInt32(Program.GetCount("длинну массива B | должна быть не больше длины массива А"));
            }
            double[] a = new double[lA];
            for (int i = 0; i < lA - lB; i++)
            {
                double c = Program.GetCount(Convert.ToString(i + 1));
                a[i] = c;
            }
            Program.PrintArr(a);
            Console.WriteLine();
            double[] b = new double[lB];
            for (int i = 0; i < lB; i++)
            {
                double c = Program.GetCount(Convert.ToString(i + 1));
                b[i] = c;
            }
            Program.PrintArr(b);          
            int k = Convert.ToInt32(Program.GetCount("k, 0 => k < длинa первого массива-1"));
            while (k < 0 || k >= lA - lB - 1)
            {
                k = Convert.ToInt32(Program.GetCount("k, 0 => k < длинa первого массивa-1"));
            }
            for (int i = lA - 1, j = lA - lB - 1; j > k; j--)
            {
                a[i] = a[j];
                i--;
            }
            for (int i = k + 1, j = 0; j < b.Length; j++)
            {
                a[i] = b[j];
                i++;
            }
            Program.PrintArr(a);
        }
        public static void Task16()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int end = -1, start = 0;
            if (end == -1) end = arr.Length;
            double middle;
            double sum = Program.GetArrSum(arr, start, end);
            end--;
            middle = sum / (end - start + 1);
            int l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < middle) l++;
            }
            int[] res = new int[l];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (arr[i] < middle)
                {
                    res[j] = i;
                    j++;
                }
            }
            Program.PrintArr(res);
        }
        public static void Task17()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
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
            double middle = 0;
            int l = 0;
            if (maxIdx < minIdx)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        l++;
                        middle += arr[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        l++;
                        middle += arr[i];
                    }
                }               
            }
            if (l == 0) l = 1;
            middle /= l;
            Console.WriteLine(middle);
        }
        public static void Task18()
        {
            double[] arr = Program.GetArr();
            Program.PrintArr(arr);
            int a = 0;
            double A = arr[0];
            int b = 1;
            double B = arr[1];
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr[i] > A)
                {
                    a = i;
                    A = arr[i];
                }
            }
            for (int i = 1; i < arr.Length; i += 2)
            {
                if (arr[i] > B)
                {
                    b = i;
                    B = arr[i];
                }
            }
            if (a > b)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    arr[i] = 0;
                }
            }
            else
            {
                for (int i = arr.Length / 2; i < arr.Length; i++)
                {
                    arr[i] = 0;
                }
            }
            Program.PrintArr(arr);
        }
        public static void Task19()
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
            double sum = Program.GetArrSum(arr);
            if (arr[maxIdx] > sum)
            {
                arr[maxIdx] = 0;
            }
            else
            {
                arr[maxIdx] *= 2;
            }
            Program.PrintArr(arr);
        }
        public static void Task20()
        {
            double[] arr = Program.GetArr();
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
            int negative = -1;
            int start;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negative = i;
                    break;
                }
            }
            if (negative == -1) negative = minIdx;
            if (negative < minIdx)
            {
                start = 0;
            }
            else
            {
                start = 1;
            }
            double sum = Program.GetArrSum(arr, start, arr.Length, 2);
            Console.WriteLine(sum);
        }
    }
}
