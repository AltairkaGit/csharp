using System;
using System.Collections.Generic;
using System.Text;

namespace matrix
{
    class Lab1
    {
        public static void Task1()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(0, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double sum = Program.GetSum(matrix, raws, columns);
            Console.WriteLine(sum);
        }
        public static void Task2()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-10, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            int n = 0;
            double sum = 0;
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    double c = matrix[i, j];
                    if (c > 0)
                    {
                        sum += c;
                        n++;
                    }
                }
            }
            double middle = sum / n;
            Console.WriteLine(n);
            Console.WriteLine(middle);
        }
        public static void Task3()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(0, 10, 4, 4);
            Program.PrintMatrix(matrix, raws, columns);
            double path = Program.GetPath(matrix, raws, columns);
            Console.WriteLine(path);
        }
        public static void Task4()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(0, 10, 3, 6);
            Program.PrintMatrix(matrix, raws, columns);
            (int raw, int column) = Program.FindMatrixMin(matrix, raws, columns);
            Console.WriteLine($"{raw}  {column} | элемент {matrix[raw, column]}");
        }
        public static void Task5()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 4);
            int column = Program.GetInt("столбец");
            column--;
            int raw = -1;
            Program.PrintMatrix(matrix, raws, columns);
            double[] columnArr = Program.GetColumn(matrix, column, raws);
            //находим 1 отрицательный
            for(int i = 0; i < columnArr.Length; i++)
            {
                if (columnArr[i] < 0)
                {
                    raw = i;
                    break;
                }
            }
            if (raw == -1)
            {
                Console.WriteLine("Тут нет отрицательного элемента");
                return;
            }
            Console.WriteLine($"{raw + 1} | {matrix[raw, column]}");
        }
        public static void Task6()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 4, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] idxs = new double[4];
            for (int i = 0; i < idxs.Length; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int min = Program.FindMin(raw);
                idxs[i] = min;
            }
            Program.PrintRaw(idxs);
        }
        public static void Task7()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 3, 5);
            Program.PrintMatrix(matrix, raws, columns);
            double[] idxs = new double[5];
            for (int i = 0; i < idxs.Length; i++)
            {
                double[] column = Program.GetColumn(matrix, i, raws);
                int max = Program.FindMax(column);
                idxs[i] = max;
            }
            Program.PrintRaw(idxs);
        }
        public static void Task8()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 4, 6);
            Program.PrintMatrix(matrix, raws, columns);
            double[] positives = new double[4];
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                positives[i] = Program.GetMiddle(raw, (c) => c > 0);                
            }
            Program.PrintRaw(positives);
        }
        public static void Task9()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                if (max == 0) continue;
                matrix[i, max] = raw[0];
                matrix[i, 0] = raw[max];
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task10()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);            
            double[] column = Program.GetColumn(matrix, 2, raws);
            int max = Program.FindMax(column);
            if (max != 3)
            {
                double[] maxRaw = Program.GetRaw(matrix, max, columns);
                for (int i = 0; i < columns; i++)
                {
                    matrix[max, i] = matrix[3, i];
                    matrix[3, i] = maxRaw[i];
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task11()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] column = Program.GetColumn(matrix, 0, raws);
            int min = Program.FindMin(column);
            if (min != 4)
            {
                for (int i = min; i < raws - 1; i++)
                {
                    Program.SwapRaws(matrix, i, columns);
                }                
            }
            //Удаляем последнюю строку
            for (int i = 0; i < columns; i++)
            {
                matrix[raws - 1, i] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task12()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 7);
            Program.PrintMatrix(matrix, raws, columns);
            (int maxRaw, int maxCol) = Program.FindMatrixMax(matrix, raws, columns);
            //Утащили столбец с максимальным в конец
            for (int i = maxCol; i < columns - 1; i++)
            {
                Program.SwapColumns(matrix, i, raws);
            }
            //Утащли строку в конце
            for (int i = maxRaw; i < raws - 1; i++)
            {
                Program.SwapRaws(matrix, i, columns);
            }
            //Удаляем последнюю строку
            for (int i = 0; i < columns; i++)
            {
                matrix[raws - 1, i] = 0;
            }
            //Удаляем последний столбец
            for (int i = 0; i < raws; i++)
            {
                matrix[i, columns - 1] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task13()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 5);
            Program.PrintMatrix(matrix, raws, columns);
            double[] diagonal = Program.GetDiagonal(matrix, raws, columns);
            int max = Program.FindMax(diagonal);
            if (max != 3)
            {
                Program.SwapColumns(matrix, max, raws, 3);
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task14()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 4, 3);
            Program.PrintMatrix(matrix, raws, columns);
            //Создаем массив равный столбцам
            double[] arr = new double[columns];
            //Обходим матрицу по столбцам
            for (int i = 0; i < columns; i++)
            {                
                //Наши отрицательные элементы
                int k = 0;
                //Проходим столбец по строкам
                for (int j = 0; j < raws; j++)
                {
                    //Если отрицательный - увеличиваем k
                    if (matrix[j, i] < 0) k++;
                }
                arr[i] = k;
            }
            Program.PrintRaw(arr);
        }
        public static void Task15()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                matrix[i, max] *= i + 1;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task16()
        {
            int n = Program.GetInt("строки");
            int m = Program.GetInt("столбцы");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, m);
            Program.PrintMatrix(matrix, raws, columns);
            //Обходим матрицу по столбцам
            for (int i = 0; i < columns; i++)
            {
                //Тащим столбец
                double[] column = Program.GetColumn(matrix, i, raws);
                int max = Program.FindMax(column);
                //Теперь тащим максимальный в конец
                for (int j = max; j < raws - 1; j++)
                {
                    Program.SwapInColumn(matrix, i, j);
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task17()
        {
            int n = Program.GetInt("строки");
            int m = Program.GetInt("столбцы");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, m);
            Program.PrintMatrix(matrix, raws, columns);
            //Обходим матрицу по столбцам
            for (int i = 0; i < columns; i++)
            {
                //Тащим столбец
                double[] column = Program.GetColumn(matrix, i, raws);
                int min = Program.FindMin(column);
                //Теперь тащим минимальный в начало
                for (int j = min; j > 0; j--)
                {
                    Program.SwapInColumn(matrix, i, j, j - 1);
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task18()
        {
            int n = Program.GetInt("строки");
            int m = Program.GetInt("столбцы");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, m);
            Program.PrintMatrix(matrix, raws, columns);
            //Обходим матрицу по строкам
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int firstNegative = Program.FindFirstNegative(raw);
                if (firstNegative < 1) continue;
                //Находим максимальное до 1 отрицательного
                int max = Program.FindMax(raw, 0, firstNegative);
                int lastNegative = Program.FindLastNegative(raw);
                //Теперь просто меняем местами
                Program.Swap(raw, max, lastNegative);
                //И заменяем в матрице
                matrix[i, max] = raw[max];
                matrix[i, lastNegative] = raw[lastNegative];
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task19()
        {
            int n = Program.GetInt("строки");
            int m = Program.GetInt("столбцы");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, m);
            Program.PrintMatrix(matrix, raws, columns);
            //Обходим матрицу по строкам
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                for (int j = 0; j < max; j++)
                {
                    if (raw[j] < 0)
                    {
                        matrix[i, j] /= raw[max];
                    }
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task20()
        {
            int n = Program.GetInt("строки");
            int m = Program.GetInt("столбцы");
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, n, m);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                int firstNegative = Program.FindFirstNegative(raw);
                if (firstNegative == -1) continue;
                int lastNegative = Program.FindLastNegative(raw);
                matrix[i, max] = (raw[firstNegative] + raw[lastNegative]) / 2;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task21()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            //Т.к. мне лень менять метод, заполним 
            //последний нулями и будем считатать
            //что изначально заполнены только 6
            for (int i = 0; i < raws; i++)
            {
                matrix[i, 6] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
            //Сначала заполним последний столбец
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw, 0, 6);
                matrix[i, 6] = matrix[i, max];
            }
            //Теперь поменяем местами последний и предпоследний столбец
            Program.SwapColumns(matrix, 5, raws);
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task22()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 8);
            Program.PrintMatrix(matrix, raws, columns);
            (int maxRaw, int maxCol) = Program.FindMatrixMax(matrix, raws, columns);
            double middle = Program.GetMiddle(matrix, raws, columns, c => c > 0, true);
            matrix[maxRaw, maxCol] = middle;
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task23()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            for (int i = 0; i < raws; i++)
            {
                matrix[i, 6] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw, 0, 6);
                if (max == 5)
                {
                    matrix[i, 6] = raw[max];
                    continue;
                }
                //Тащим последний элемент, чтобы 
                //стоял после максимума
                for (int j = columns - 2; j > max; j--)
                {
                    Program.SwapInRaw(matrix, i, j);
                }
                //Дублируем максимум
                matrix[i, max + 1] = raw[max];
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task24()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 5);
            Program.PrintMatrix(matrix, raws, columns);
            //Обходим по строкам
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                //Находим индекс максимального элемента
                //Если это не начало и не конец
                //Найдем среднее
                //И заменим в цикле все отрицалельные
                //Перед максимальными на среднее
                if (max < raw.Length - 1 && max > 0)
                {
                    double middle = Program.GetMiddle(raw, c => c > 0, false, max);
                    //Тут 
                    for (int j = 0; j < max; j++)
                    {
                        if (raw[j] < 0)
                        {
                            matrix[i, j] = middle;
                        }
                    }
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task25()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 5);
            Program.PrintMatrix(matrix, raws, columns);
            double[] negatives = new double[raws];
            //Обходим по строкам
            for (int i = 0; i < raws; i++)
            {
                int n = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0) n++;
                }
                negatives[i] = n;
            }
            int min = Program.FindMin(negatives);
            int max = Program.FindMax(negatives);
            Program.SwapRaws(matrix, min, columns, max);
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task26()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] column = Program.GetColumn(matrix, 5, raws);
            int max = Program.FindMax(column);
            //Т.к. у нас 7 солбцов, то вектор длинной 7
            //Значит что каждый элемент строки  единица
            for (int i = 0; i < columns; i++)
            {
                matrix[max, i] = 1;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task27()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] maxs = new double[raws];
            //Заполняем массив с конца
            for(int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                maxs[maxs.Length - 1 - i] = raw[max];
            }
            //Осталось поменять 4 столбец
            for(int i = 0; i < raws; i++)
            {
                matrix[i, 3] = maxs[i];
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task28()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 7, 5);
            Program.PrintMatrix(matrix, raws, columns);
            double[] sums = new double[raws];
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                sums[i] = Program.GetSum(raw, c => c > 0);
            }
            int max = Program.FindMax(sums);
            //Потащим эту строку в конц, чтобы удалить
            for (int i = max; i < raws - 1; i++)
            {
                Program.SwapRaws(matrix, i, columns);
            }
            //Удалим строку
            for (int i = 0; i < columns; i++)
            {
                matrix[6, i] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task29()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] raw = Program.GetRaw(matrix, 1, columns);
            int min = Program.FindMin(raw, c => Math.Abs(c));
            //Утащим столбец с минимальным в конец
            for (int i = min; i < columns - 1; i++)
            {
                Program.SwapColumns(matrix, i, raws);
            }
            //Удаляем
            for (int i = 0;  i < raws; i++)
            {
                matrix[i, 6] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task30()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-2, 10, 5, 5);
            Program.PrintMatrix(matrix, raws, columns);
            double[] diagonal = Program.GetDiagonal(matrix, raws, columns);
            double[] column = Program.GetColumn(matrix, 2, raws);
            int negative = Program.FindFirstNegative(column);
            int max = Program.FindMax(diagonal);
            Program.SwapRaws(matrix, max, columns, negative);
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task31()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 8);
            for (int i = 0; i < raws; i++)
            {
                matrix[i, 7] = 0;
            }
            Program.PrintMatrix(matrix, raws, columns);
            double[] raw = Program.GetRaw(matrix, 4, columns);
            int min = Program.FindMin(raw);
            for (int i = columns - 1; i > min; i--)
            {
                Program.SwapColumns(matrix, i - 1, raws);
            }
            for (int i = 0; i < raws; i++)
            {
                matrix[i, min] = 1;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task32()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i< raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                double middle = Program.GetMiddle(raw, c => c > 0, true);
                matrix[i, max] = middle;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task33()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            int l = 0;
            //Найдем длину нашего одномерного массива
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0) l++;
                }
            }
            double[] arr = new double[l];
            l = 0;
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        arr[l] = matrix[i, j];
                        l++;
                    }
                }
            }
            Program.PrintRaw(arr);
        }
    }
}
