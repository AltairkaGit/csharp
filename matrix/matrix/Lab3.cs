using System;
using System.Collections.Generic;
using System.Text;

namespace matrix
{
    class Lab3
    {
        public static void Task1()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 7, 5);
            Program.PrintMatrix(matrix, raws, columns);            
            double[] negatives = new double[columns];
            //Пойдем по столбцам посчитаем отрицательные в каждом
            for (int i = 0; i < columns; i++)
            {
                int n = 0;
                for (int j = 0; j < raws; j++)
                {
                    if (matrix[j, i] < 0) n++;
                }
                negatives[i] = n;
            }
            Program.PrintArr(negatives);
            //Теперь сортируя массив с отрицательными
            //Будем перествавлять столбцы
            double temp;
            for (int i = 0; i < negatives.Length - 1; i++)
            {
                for (int j = i + 1; j < negatives.Length; j++)
                {
                    if (negatives[i] > negatives[j])
                    {
                        //Тут меняем числа массива
                        temp = negatives[i];
                        negatives[i] = negatives[j];
                        negatives[j] = temp;
                        //Тут меняем столбцы
                        Program.SwapColumns(matrix, i, raws, j);
                    }
                }
            }
            Program.PrintArr(negatives);
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task2()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 7, 7);
            Program.PrintMatrix(matrix, raws, columns);
            //Пойдем снова по строчкам
            for (int i = 0; i < raws; i++)
            {
                matrix[0, i] = 0;
                matrix[i, 0] = 0;
                matrix[raws - 1, i] = 0;
                matrix[i, raws - 1] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task3()
        {
            int n = Program.GetInt("n");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, n);
            Program.PrintMatrix(matrix, raws, columns);
            double[] result = new double[2 * n - 1];
            int k = result.Length / 2;
            //Пойдем считать суммы диагоналей
            for (int i = 0; i < raws; i++)
            {
                double[] right = Program.GetDiagonal(matrix, 0, i, raws, columns);
                double[] left = Program.GetDiagonal(matrix, i, 0, raws, columns);
                double sumRight = Program.GetSum(right);
                double sumLeft = Program.GetSum(left);
                result[k + i] = sumRight;
                result[k - i] = sumLeft;
            }
            //Раслолагаютя от левой нижней до верхней правой
            Program.PrintArr(result);
        }
        public static void Task4()
        {
            int n = Program.GetInt("n");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, n);
            Program.PrintMatrix(matrix, raws, columns);
            //Идем построкам снизу и потащим нижний правый элемент главной диагонали т.к. матрица квадратная
            //Пойдем до средней строки и по столбцам пока меньше главной диагонали зануляем
            for (int i = raws - 1, k = raws - 1; i >= raws / 2; i--, k--)
            {
                for (int j = 0; j < k; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task5()
        {
            int n = Program.GetInt("n");
            int k = Program.GetInt($"1 <= k <= {n}");
            //теперь к - индекс
            k--;
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-5, 6, n, n);
            Program.PrintMatrix(matrix, raws, columns);
            (int maxRaw, int maxColumn) = Program.FindMatrixMax(matrix, c => Math.Abs(c), raws, columns);
            //а - что больше к или индекс максимальной строки
            int a = k > maxRaw ? k : maxRaw;
            //b -  что меньше
            int b = k < maxRaw ? k : maxRaw;
            for (int i = b; i < a; i++)
            {
                Program.SwapRaws(matrix, i, columns);
            }
            //то же самое для столбцов
            a = k > maxColumn ? k : maxColumn;
            b = k < maxColumn ? k : maxColumn;
            for (int i = b; i < a; i++)
            {
                Program.SwapColumns(matrix, i, raws);
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task6()
        {
            int n = Program.GetInt("n");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(0, 10, n, n);
            Program.PrintMatrix(matrix, raws, columns);
            //l - количество элементов матрицы
            int l = matrix.Length;
            //Верхний треугольниц матрицы: элементы главной диагонали = n
            //И длинна массива - главная диагональ, пополам + n
            double[] right = new double[(l - n) / 2 + n];
            //Левый просто пополам длину - главную диагональ
            double[] left = new double[(l - n) / 2];
            //Теперь заполним массивы, пойдем по строкам
            for (int i = 0, r = 0, k = 0; i < raws; i++)
            {
                //тут правый
                for (int j = i; j < columns; j++)
                {
                    right[r] = matrix[i, j];
                    r++;
                }
                //тут левый
                for (int j = 0; j < i; j++)
                {
                    left[k] = matrix[i, j];
                    k++;
                }
            }
            //т.к. вывод надо по строкам, то стандарный метод не пойдет
            //выведем правый
            for (int i = 0, k = 0; k < right.Length; i++)
            {
                //Пробелы перед
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < n - i; j++)
                {                    
                    Console.Write($" {right[k]}");
                    k++;
                }
                Console.WriteLine();
            }
            //теперь левый
            for (int i = 0, k = 0; k < left.Length; i++)
            {                
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($" {left[k]}");
                    k++;
                }
                //Пробелы после тут вообще не нужны
                Console.WriteLine();
            }
        }
        public static void Task7()
        {
            int n = Program.GetInt("n");
            int triangleLen = n + (n * n - n) / 2;
            double[] triangleA = Program.GetRandomArr(triangleLen, 0, 10);
            double[] triangleB = Program.GetRandomArr(triangleLen, 0, 10);
            Program.PrintMatrix(triangleA, n);
            Program.PrintMatrix(triangleB, n);
            //Т.к. матрицы квадратные, то результат умножения та же квадратная матрица
            //Такого же размера n x n
            double[] result = new double[n * n];
            double[] a = Program.TriangleToMatrixArr(triangleA, n);
            double[] b = Program.TriangleToMatrixArr(triangleB, n);
            for (int i = 0; i < n * n; i++)
            {                
                //2 цикла - проход по строке матрицы
                //чтобы найти результат умножения
                //надо умножить строку на столбец
                //но т.к. тут все хитро, моно строку 
                //на строку с номером столбца
                int raw = i / n;
                int col = i - n * raw;
                for (int j = 0; j < n; j++)
                {
                    result[i] += a[raw * n + j] * b[col * n + j];
                }
            }
            Program.PrintArrToMatrix(result, n);
        }
        public static void Task10()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 8);            
            Program.PrintMatrix(matrix, raws, columns);
            //Начнем упорядочивание
            double temp;
            int step = 2;            
            for (int i = 0; i < raws; i++)
            {
                //Чтобы не горожить кучу условий                
                //Тут пройдемся по четным - они по убыванию
                for (int j = 0; j < columns - step; j += step)
                {
                    bool replaced = false;
                    for (int k = j; k < columns; k += step)
                    {
                        if (matrix[i, j] < matrix[i, k])
                        {
                            temp = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temp;
                            replaced = true;
                        }
                    }
                    if (replaced == false) break;
                }
                //A тут по нечетным - они по возрастанию
                for (int j = 1; j < columns - step; j += step)
                {
                    bool replaced = false;
                    for (int k = j; k < columns; k += step)
                    {
                        if (matrix[i, k] < matrix[i, j])
                        {
                            temp = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temp;
                            replaced = true;
                        }
                    }
                    if (replaced == false) break;
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
    }
}
