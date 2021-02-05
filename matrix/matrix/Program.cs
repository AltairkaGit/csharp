using System;

namespace matrix
{
    public class Program
    {
        public static double GetCount(string word)
        {
            Console.Write($"Введите {word}: ");
            return Double.Parse(Console.ReadLine().Trim());
        }
        public static int GetInt(string word)
        {
            return Convert.ToInt32(GetCount(word));
        }
        public static void Swap(double[] arr, int start, int end = -1)
        {
            end = end == -1 ? start + 1 : end;
            double temp;
            temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }
        public static void SwapInColumn(double[,] matrix, int column, int start, int end= -1)
        {
            end = end == -1 ? start + 1 : end;
            double temp;
            temp = matrix[start, column];
            matrix[start, column] = matrix[end, column];
            matrix[end, column] = temp;
        }
        public static void SwapInRaw(double[,] matrix, int raw, int start, int end = -1)
        {
            end = end == -1 ? start + 1 : end;
            double temp;
            temp = matrix[raw, start];
            matrix[raw, start] = matrix[raw, end];
            matrix[raw, end] = temp;
        }
        public static (double[,], int, int) GetEmptyMatrix(int raws = -1, int columns = -1)
        {
            if (raws == -1) raws = GetInt("число строк");
            if (columns == -1) columns = GetInt("число столбцов");
            double[,] matrix = new double[raws, columns];
            return (matrix, raws, columns);
        }
        public static (double[,], int, int) GetMatrix(int a = -1, int b = -1)
        {
            (double[,] matrix, int raws, int columns) = GetEmptyMatrix(a, b);
            for (int i = 0; i < raws; i++)
            {
                Console.WriteLine($"Ввод {i + 1} строки:");
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = GetCount($"{j + 1}");
                }
            }
            return (matrix, raws, columns);
        }
        public static (double[,], int, int) GetRandomMatrix(int start, int end, int height = -1, int width = -1)
        {
            (double[,] matrix, int raws, int columns) = GetEmptyMatrix(height, width);
            Random rand = new Random();
            for (int i = 0; i < raws; i++)
            {                
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(start, end);
                }
            }
            return (matrix, raws, columns);
        }
        public static double[] GetRandomArr(int lenght, int start, int end)
        {
            double[] arr = new double[lenght];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(start, end);
            }
            return arr;
        }
        public static double GetSum(double[] arr, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            double sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static double GetSum(double[] arr, Func<double, bool> Callback, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            double sum = 0;
            for (int i = start; i < end; i++)
            {
                double c = arr[i];
                if (Callback(c))
                {
                    sum += c;
                }
            }
            return sum;
        }
        public static double GetSum(double[,] matrix, int raws, int columns)
        {
            double sum = 0;
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    double c = matrix[i, j];
                    sum += c;
                }
            }
            return sum;
        }
        public static double GetPath(double[,] matrix, int raws, int columns)
        {
            double path = 0;
            double[] diagonal = Program.GetDiagonal(matrix, raws, columns);
            path += Program.GetSum(diagonal);
            return path;
        }
        public static double[] GetRaw(double[,] matrix, int raw, int columns)
        {
            double[] arr = new double[columns];
            for (int i = 0; i < columns; i++)
            {
                arr[i] = matrix[raw, i];
            }
            return arr;
        }
        public static double[] GetColumn(double[,] matrix, int column, int raws)
        {
            double[] arr = new double[raws];
            for (int i = 0; i < raws; i++)
            {
                arr[i] = matrix[i, column];
            }
            return arr;
        }
        public static void CheckSqare(int raws, int columns)
        {
            if (raws != columns)
            {
                Console.WriteLine("матрица не квадратная");
                throw new Exception("матрица не квадратная!");
            }
        }
        public static double[] GetDiagonal(double[,] matrix, int raws, int columns)
        {
            CheckSqare(raws, columns);
            double[] diagonal = new double[raws];
            for (int i = 0; i < raws; i++)
            {
                diagonal[i] = matrix[i, i];
            }
            return diagonal;
        }
        public static double[] GetDiagonal(double[,] matrix, int raw, int column, int raws, int columns)
        {
            CheckSqare(raws, columns);
            if (raw > 0 && column > 0)
            {
                Console.WriteLine("для работы либо строка 0 столбец больше либо наоборот");
                throw new Exception("для работы либо строка 0 столбец больше либо наоборот");
            }
            int len = columns - raw - column;
            double[] diagonal = new double[len];
            for (int i = 0; i < len; i++)
            {
                diagonal[i] = matrix[raw, column];
                raw++;
                column++;
            }
            return diagonal;
        }
        public static int FindMin(double[] arr, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            int idx = start;
            double min = arr[idx];
            for (int i = start; i < end; i++)
            {
                if (arr[i] < min)
                {
                    idx = i;
                    min = arr[i];
                }
            }
            return idx;
        }
        public static int FindMin(double[] arr, Func<double, double> Callback, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            int idx = start;
            double min = Callback(arr[idx]);
            for (int i = start; i < end; i++)
            {
                double c = Callback(arr[i]);
                if (c < min)
                {
                    idx = i;
                    min = c;
                }
            }
            return idx;
        }
        public static int FindMax(double[] arr, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            int idx = start;
            double max = arr[idx];
            for (int i = start; i < end; i++)
            {
                if (arr[i] > max)
                {
                    idx = i;
                    max = arr[i];
                }
            }
            return idx;
        }
        public static int FindMax(double[] arr, Func<double, double> Callback, int start = 0, int end = -1)
        {
            end = end == -1 ? arr.Length : end;
            int idx = start;
            double max = Callback(arr[idx]);
            for (int i = start; i < end; i++)
            {
                double c = Callback(arr[i]);
                if (c > max)
                {
                    idx = i;
                    max = c;
                }
            }
            return idx;
        }
        public static int FindLastNegative(double[] arr)
        {
            int idx = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] < 0)
                {
                    idx = i;
                    break;
                }
            }
            return idx;
        }
        public static int FindFirstNegative(double[] arr)
        {
            int idx = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    idx = i;
                    break;
                }
            }
            return idx;
        }
        public static (int, int) FindMatrixMin(double[,] matrix, int raws, int columns)
        {
            int raw = 0;
            int column = 0;
            double min = matrix[0, 0];
            for (int i = 0; i < raws; i++)
            {
                int curRaw = i;
                double[] rawArr = GetRaw(matrix, curRaw, columns);
                int curColumn = FindMin(rawArr);
                curColumn = curColumn == -1 ? 0 : curColumn;
                double curMin = matrix[curRaw, curColumn];
                if (curMin < min)
                {
                    min = curMin;
                    raw = curRaw;
                    column = curColumn;
                }
            }
            return (raw, column);
        }
        public static (int, int) FindMatrixMax(double[,] matrix, int raws, int columns)
        {
            int raw = 0;
            int column = 0;
            double max = matrix[0, 0];
            for (int i = 0; i < raws; i++)
            {
                int curRaw = i;
                double[] rawArr = GetRaw(matrix, curRaw, columns);
                int curColumn = FindMax(rawArr);
                curColumn = curColumn == -1 ? 0 : curColumn;
                double curMax = matrix[curRaw, curColumn];
                if (curMax > max)
                {
                    max = curMax;
                    raw = curRaw;
                    column = curColumn;
                }
            }
            return (raw, column);
        }
        public static (int, int) FindMatrixMax(double[,] matrix, Func<double, double> Callback, int raws, int columns)
        {
            int raw = 0;
            int column = 0;
            double max = matrix[0, 0];
            for (int i = 0; i < raws; i++)
            {
                int curRaw = i;
                double[] rawArr = GetRaw(matrix, curRaw, columns);
                int curColumn = FindMax(rawArr, Callback);
                curColumn = curColumn == -1 ? 0 : curColumn;
                double curMax = Callback(matrix[curRaw, curColumn]);
                if (curMax > max)
                {
                    max = curMax;
                    raw = curRaw;
                    column = curColumn;
                }
            }
            return (raw, column);
        }
        public static double GetMiddle(double[] arr, Func<double, bool> Callback, bool fromPassed = false, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            double sum = 0;
            double c;
            int n = 0;
            for (int i = start; i < end; i++)
            {
                c = arr[i];
                if (Callback(c))
                {
                    sum += c;
                    n++;
                }
            }
            sum /= fromPassed ? n : arr.Length;
            return sum;
        }
        public static double GetMiddle(double[,] matrix, int raws, int columns, Func<double, bool> Callback, bool fromPassed = false)
        {
            double sum = 0;
            double c;
            int n = 0;
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    c = matrix[i, j];
                    if (Callback(c))
                    {
                        sum += c;
                        n++;
                    }
                }
            }
            sum /= fromPassed ? n : matrix.Length;
            return sum;
        }
        public static void SwapRaws(double[,] matrix, int from, int columns,  int to = -1)
        {
            if (to == -1) to = from + 1;
            double[] temp = GetRaw(matrix, to, columns);
            for (int i = 0; i < columns; i++)
            {
                matrix[to, i] = matrix[from, i];
                matrix[from, i] = temp[i];
            }
        }
        public static void SwapColumns(double[,] matrix, int from, int raws, int to = -1)
        {
            if (to == -1) to = from + 1;
            double[] temp = GetColumn(matrix, to, raws);
            for (int i = 0; i < raws; i++)
            {
                matrix[i, to] = matrix[i, from];
                matrix[i, from] = temp[i];
            }
        }
        public static void PrintRaw(double[] arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;            
            for (int i = start; i < end; i++)
            {                
                Console.Write($" {arr[i]} ");
            }
        }
        public static void PrintColumn(double[] arr, int start = 0, int end = -1)
        {
            if (end == -1) end = arr.Length;
            for (int i = start; i < end; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
        }
        public static double[,] TranspMatrix(double[,] matrix, int raws, int columns)
        {
            double[,] transp = new double[columns, raws];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < raws; j++)
                {
                    transp[i, j] = matrix[j, i];
                }
            }
            return transp;

        }
        public static void PrintArr(double[] arr, int start = 0, int end = -1)
        {
            PrintRaw(arr, start, end);
            Console.WriteLine();
            Console.WriteLine();
        }
        public static double[] TriangleToMatrixArr(double[] triangle, int n)
        {
            double[] arr = new double[n * n];
            int l = 0;
            for (int i = 0, a = 0; i < n; i++)
            {
                for (int j = 0, k = i; j < i; j++)
                {
                    arr[l] = triangle[k];
                    l++;
                    k += n - j - 1;
                }
                for (int j = 0; j < n - i; j++, a++)
                {
                    arr[l] = triangle[a];
                    l++;
                }
                Console.WriteLine();
            }
            return arr;
        }
        public static void PrintMatrix(double[,] matrix, int raws, int columns)
        {            
            //Тут будут максимальные длины столбцов
            int[] lengths = new int[columns];
            //Найдем эти максимальные длины
            for (int i = 0; i < columns; i++)
            {
                int maxLen = Convert.ToString(matrix[0, i]).Length;
                for (int j = 0; j < raws; j++)
                {
                    int cLen = Convert.ToString(matrix[j, i]).Length;
                    if (cLen > maxLen) maxLen = cLen;
                }
                lengths[i] = maxLen;
            }
            //Теперь отрисуем матрицу
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int maxLen = lengths[j];
                    double c = matrix[i, j];
                    int cLen = Convert.ToString(c).Length;
                    int d = maxLen - cLen;
                    for (int k = 0; k < d; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write($" {c} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintMatrix(double[] triangle, int n)
        {            
            for (int i = 0, a = 0; i < n; i++)
            {
                for (int j = 0, k = i; j < i; j++)
                {
                    Console.Write($" {triangle[k]}");
                    k += n - j - 1;
                }
                for (int j = 0; j < n - i; j++, a++)
                {
                    Console.Write($" {triangle[a]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintArrToMatrix(double[] arr, int n)
        {
            for (int i = 0, a = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($" {arr[a]}");
                    a++;
                }                
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Lab3.Task10();
        }
    }
}
