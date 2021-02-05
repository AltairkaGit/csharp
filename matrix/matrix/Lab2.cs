using System;
using System.Collections.Generic;
using System.Text;

namespace matrix
{
    class Lab2
    {
        public static void Task1()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < raws; i++)
            {
                double[] raw = Program.GetRaw(matrix, i, columns);
                int max = Program.FindMax(raw);
                int left = max - 1;
                int right = max + 1;
                if (left < 0)
                {
                    matrix[i, right] *= 2;
                    continue;
                }
                else if (right >= columns)
                {
                    matrix[i, left] *= 2;
                    continue;
                }
                else
                {
                    int min = raw[right] < raw[left] ? right : left;
                    matrix[i, min] *= 2;
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task2()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 7, 5);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < columns; i++)
            {
                double[] column = Program.GetColumn(matrix, i, raws);
                int positives = 0;
                int negatives = 0;
                for (int j = 0; j < raws; j++)
                {
                    double c = column[j];
                    if (c < 0) negatives++;
                    if (c > 0) positives++;

                }
                int max = Program.FindMax(column);
                matrix[max, i] = positives > negatives ? 0 : max;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task3()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 10, 5);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < columns; i++)
            {
                double[] column = Program.GetColumn(matrix, i, raws);
                int max = Program.FindMax(column);
                if (max < raws / 2)
                {
                    double sum = Program.GetSum(column, max + 1);            
                    matrix[0, i] = sum;
                }
                    
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task4()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 5, 7);
            Program.PrintMatrix(matrix, raws, columns);
            double[] arr = Program.GetRandomArr(5, 10, 50);
            Program.PrintArr(arr);
            for (int i = 0; i < columns; i++)
            {
                double[] column = Program.GetColumn(matrix, i, raws);
                int max = Program.FindMax(column);
                double temp = arr[max];
                matrix[max, i] = matrix[max, i] > temp ? matrix[max, i] : temp;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task5()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 7, 5);
            Program.PrintMatrix(matrix, raws, columns);
            for (int i = 0; i < columns; i++)
            {
                double[] column = Program.GetColumn(matrix, i, raws);
                int max = Program.FindMax(column);
                double temp = (column[0] + column[columns - 1]) / 2;
                matrix[max, i] = matrix[max, i] > temp ? max : temp;
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task6()
        {
            int n = Program.GetInt("n");
            (double[,] matrix, int raws, int columns) = Program.GetEmptyMatrix(n, 3 * n);
            int k;
            for (int i = 0; i < raws; i++)
            {
                k = i;
                for (int j = 0; j < columns; j++)
                {
                    if (j == k)
                    {
                        k += n;
                        matrix[i, j] = 1;                        
                    }
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task7()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 6);
            Program.PrintMatrix(matrix, raws, columns);
            double[] diagonal = Program.GetDiagonal(matrix, raws, columns);
            int max = Program.FindMax(diagonal);
            if (max > 0)
            {
                //Если максимальный на диагонали не в 1 строке то
                //Начинаем идти по строкам
                for (int i = 0; i < max; i++)
                {
                    //и заменять элементы уже не с 0-го а с i + 1 
                    //т.к. тот лежит на диагонали, до конца строки
                    for (int j = i + 1; j < columns; j++)
                    {                        
                        matrix[i, j] = 0;
                    }
                }
            }            
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task8()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 6);
            Program.PrintMatrix(matrix, raws, columns);
            //Пойдем по строка, но через 1
            for (int i = 0, j = 1; i < raws; i += 2, j += 2)
            {
                double[] thisRaw = Program.GetRaw(matrix, i, columns);
                double[] nextRaw = Program.GetRaw(matrix, j, columns);
                //Теперь найдем максимумы этой и следующей строки
                int thisMax = Program.FindMax(thisRaw);
                int nextMax = Program.FindMax(nextRaw);
                //Меняем
                matrix[i, thisMax] = nextRaw[nextMax];
                matrix[j, nextMax] = thisRaw[thisMax];
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
        public static void Task9()
        {
            (double[,] matrix, int raws, int columns) = Program.GetRandomMatrix(-1, 10, 6, 7);
            Program.PrintMatrix(matrix, raws, columns);
            //Пойдем по строкам
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns / 2; j++)
                {
                    Program.SwapInRaw(matrix, i, j, columns - 1 - j);
                }
            }
            Program.PrintMatrix(matrix, raws, columns);
        }
    }
}
