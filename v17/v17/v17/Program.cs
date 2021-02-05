using System;

namespace v17
{
    class Program
    {
        static void Main(string[] args)
        {
            //cоздаём массив
            Console.WriteLine("Введите длину массива");
            int l = Int32.Parse(Console.ReadLine());
            int[] arr = new int[l];
            //заполняем массив
            Random rand = new Random();
            for ( int i = 0; i < l; i++)
            {
                arr[i] = rand.Next(0, 10);
            }            
            //показываем массив
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            //находим минимальный элемент
            int min = arr[0];
            int minIdx = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIdx = i;
                }
            }
            //ставим минимальный элемент в середину
            int middle = arr.Length / 2;
            int temp = arr[minIdx];
            arr[minIdx] = arr[middle];
            arr[middle] = temp;
            //сортируем первую половину по убыванию
            bool replace;            
            for (int i = 0; i < middle; i++)
            {
                replace = false;
                for (int j = i + 1; j < middle; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int c = arr[j];
                        arr[j] = arr[i];
                        arr[i] = c;
                        replace = true;
                    }
                }
                if (replace == false) break;
            }
            //теперь сортируем вторую половину по возрастанию
            for (int i = middle + 1; i < arr.Length - 1; i++)
            {
                replace = false;
                for (int j = i + 1; j < arr.Length; j++)
                {                    
                    if (arr[i] < arr[j])
                    {
                        int c = arr[j];
                        arr[j] = arr[i];
                        arr[i] = c;
                        replace = true;
                    }
                }
                if (replace == false) break;
            }
            //показываем массив
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
