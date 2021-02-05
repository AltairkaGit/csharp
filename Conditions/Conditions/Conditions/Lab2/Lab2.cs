using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    public class Lab2
    {
        public static void Task1()
        {
            double s = 0;
            int n = Program.GetCount("количество учеников");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите рост ученика ");
                s += double.Parse(Console.ReadLine());
            }
            double middle = s / n;
            Console.WriteLine("Средний рост учеников: {0}", middle);
        }
        public static void Task2()
        {
            int n = Program.GetCount("количество точек");
            int r = Program.GetCount("радиус круга");
            int a = Program.GetCount("центр круга по X");
            int b = Program.GetCount("центр круга по Y");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Program.GetCount("X");
                int y = Program.GetCount("Y");
                int sqX = (x - a) * (x - a);
                int sqY = (y - b) * (y - b);
                Console.WriteLine();
                if (r * r >= sqX + sqY)
                {
                    s++;
                }
            }
            Console.WriteLine("В круг попало {0} точек из {1}", s, n);
        }
        public static void Task3()
        {
            int n = Program.GetCount("количество учеников");
            double v = 0.2;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                int w = Program.GetCount("вес ученика(кг)");
                s += v;
                if (w < 30)
                {
                    s += v;
                }
            }
            Console.WriteLine("Понадобится {0} литров молока в день", s);

        }
        public static void Task4()
        {
            int n = Program.GetCount("количество точек");
            int r1 = Program.GetCount("радиус внутреннего круга");
            int r2 = Program.GetCount("радиус внешнего круга");
            int a = Program.GetCount("центр круга по X");
            int b = Program.GetCount("центр круга по Y");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int x = Program.GetCount("X");
                int y = Program.GetCount("Y");
                int sqX = (x - a) * (x - a);
                int sqY = (y - b) * (y - b);
                Console.WriteLine();
                if (r2 * r2 >= sqX + sqY & r1 * r1 <= sqX + sqY)
                {
                    s++;
                }
            }
            Console.WriteLine("В круг попало {0} точек из {1}", s, n);
        }
        public static void Task5()
        {
            int n = Program.GetCount("число спортсменов");
            double r = Program.GetCount("норматив");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                int a = Program.GetCount("результат очередного спортсмеа");
                if (a > 0 & a <= r)
                {
                    s++;
                }
            }
            Console.WriteLine("Норматив выполнили {0} из {1} спортсменов", s, n);
        }
        public static void Task6()
        {
            int n = Program.GetCount("количество точек");
            int a = 0;
            double b = Math.PI;
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                double x = Program.GetDouble("X");
                double y = Program.GetDouble("Y");
                double maxY = Math.Sin(x);
                if (y >= 0 & x >= a & x <= b & y <= maxY)
                {
                    s++;
                }
            }
            Console.WriteLine("В фигуру попали {0} из {1} точек", s, n);
        }
        public static void Task7()
        {
            int n = Program.GetCount("количество точек");
            int f = 0;
            int t = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Точка {0}", i + 1);
                double x = Program.GetDouble("X");
                double y = Program.GetDouble("Y");
                if (x > 0 & y > 0)
                {
                    Console.WriteLine("Точка лежит в первом квадранте");
                    f++;
                }
                else if (x < 0 & y > 0)
                {
                    Console.WriteLine("Точка лежит во втором квадранте");
                }
                else if (x < 0 & y < 0)
                {
                    Console.WriteLine("Точка лежит в третьем квадранте");
                    t++;
                }
                else if (x > 0 & y < 0)
                {
                    Console.WriteLine("Точка лежит в четвертом квадратне");
                }
                else
                {
                    Console.WriteLine("Точка лежит на осях");
                }
            }
            Console.WriteLine("В первом квадранте {0} точек, в третьем {1} точек", f, t);
        }
        public static void Task8()
        {
            int n = Program.GetCount("количество точек");
            Console.WriteLine("Точка {0}", 1);
            double fx = Program.GetDouble("X");
            double fy = Program.GetDouble("Y");
            double r = Math.Sqrt(fx * fx + fy * fy);
            int min = 0;
            double minX = fx;
            double minY = fy;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Точка {0}", i + 1);
                double x = Program.GetDouble("X");
                double y = Program.GetDouble("Y");
                double l = Math.Sqrt(x * x + y * y);
                if (l < r)
                {
                    r = l;
                    min = i + 1;
                    minX = x;
                    minY = y;
                }

            }
            Console.WriteLine("{0} наименьшее расстояние от начала координат имеет точка {1} с координатами {2} {3}", r, min, minX, minY);
        }
        public static void Task9()
        {
            int n = Program.GetCount("количество спортсменов");
            Console.WriteLine("Спортсмен {0}", 1);
            double min = Program.GetDouble("Результат: ");
            int b = 0;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("Спортсмен {0}", i + 1);
                double a = Program.GetDouble("Результат: ");
                if (a < min)
                {
                    min = a;
                    b = i;
                }
            }
            Console.WriteLine("{0} спортсмен имеет лучший результат {1}", b + 1, min);
        }
        public static void Task10()
        {
            int n = Program.GetCount("количество учеников");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ученик {0}", i + 1);
                bool isDunce = false;
                for (int j = 0; j < 4; j++)
                {
                    int mark = Program.GetCount("оценку за экзамен: ");
                    if (mark == 2 || mark == 3)
                    {
                        isDunce = true;
                    }
                }
                if (!isDunce)
                {
                    s++;
                }
            }
            Console.WriteLine("В классе {0} успевающих учеников из {1}", s, n);
        }
        public static void Task11()
        {
            int n = Program.GetCount("количество учеников");
            int s = 0;
            double a = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ученик {0}", i + 1);
                bool isDunce = false;
                for (int j = 0; j < 4; j++)
                {
                    double mark = Program.GetDouble("оценку за экзамен: ");
                    a += mark;
                    if (mark == 2 || mark == 3)
                    {
                        isDunce = true;
                    }
                }
                if (isDunce)
                {
                    s++;
                }
            }
            double middle = a / n;
            Console.WriteLine("В классе {0} неуспевающих учеников из {1} | средний балл группы: {2}", s, n, middle);
        }
        public static void Task12()
        {
            int n = Program.GetCount("количество площадей для подсчёта: ");
            for (int i = 0; i < n; i++)
            {
                double s = 0;
                double r;
                int a = Program.GetCount("Что будем считать?\n1 - площадь квадрата \n2 - площадь круга \n3 - площадь равностороннего треугольника\n");
                switch (a)
                {
                    case 1:
                        r = Program.GetCount("сторону квадрата: ");
                        s = r * r;
                        break;
                    case 2:
                        r = Program.GetCount("радиус круга: ");
                        s = Math.PI * r * r;
                        break;
                    case 3:
                        r = Program.GetCount("сторону правильного треугольника: ");
                        s = Math.Sqrt(3) * r * r / 4;
                        break;
                }
                Console.WriteLine(s);
            }
        }
        public static void Task13()
        {
            int n = Program.GetCount("пары значений: ");
            for (int i = 0; i < n; i++)
            {
                double s = 0;
                double a;
                double b;
                int c = Program.GetCount("Что будем считать?\n1 - площадь прямоульника \n2 - площадь кольца \n3 - площадь равнобудренного треугольника\n");
                switch (c)
                {
                    case 1:
                        a = Program.GetDouble("сторону A: ");
                        b = Program.GetDouble("сторону B: ");
                        s = a * b;
                        break;
                    case 2:
                        a = Program.GetDouble("радиус A: ");
                        b = Program.GetDouble("радиус B: ");
                        s = Math.PI * Math.Abs(a * a - b * b);
                        break;
                    case 3:
                        a = Program.GetDouble("основание A: ");
                        b = Program.GetDouble("сторону треугольника B: ");
                        s = Math.Sqrt(b * b - a * a / 4) * a / 2;
                        break;
                }
                Console.WriteLine(s);
            }
        }
    }
}
