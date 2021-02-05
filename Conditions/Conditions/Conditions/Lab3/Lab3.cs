using System;
using System.Collections.Generic;
using System.Text;

namespace Conditions
{
    public class Lab3
    {
        public static void Task1()
        {
            double s = 0;
            int n = 0;
            for (int i = 0; true; i++)
            {
                double m = Program.GetDouble("Введите рост ученика или -1 для завершения ввода\n");
                if (m == -1)
                {
                    break;
                }
                n++;
                s += m;
            }
            double middle = s / n;
            Console.WriteLine("Средний рост учеников: {0}", middle);
        }
        public static void Task2()
        {
            int n = 0;
            int r = Program.GetCount("радиус круга");
            int a = Program.GetCount("центр круга по X");
            int b = Program.GetCount("центр круга по Y");
            int s = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения ввода");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            double v = 0.2;
            double s = 0;
            for (int i = 0; true; i++)
            {
                int w = Program.GetCount("вес ученика(кг) или отрицательное число для завершения ввода");
                if (w < 0)
                {
                    break;
                }
                n++;
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
            int n = 0;
            int r1 = Program.GetCount("радиус внутреннего круга");
            int r2 = Program.GetCount("радиус внешнего круга");
            int a = Program.GetCount("центр круга по X");
            int b = Program.GetCount("центр круга по Y");
            int s = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения ввода");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            double r = Program.GetCount("норматив");
            int s = 0;
            for (int i = 0; true; i++)
            {
                int a = Program.GetCount("результат очередного спортсмеа или отрицательное число для завершения ввода");
                if (a < 0)
                {
                    break;
                }
                n++;
                if (a > 0 & a <= r)
                {
                    s++;
                }
            }
            Console.WriteLine("Норматив выполнили {0} из {1} спортсменов", s, n);
        }
        public static void Task6()
        {
            int n = 0;
            int a = 0;
            double b = Math.PI;
            int s = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            int f = 0;
            int t = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения ввода");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            double r = Double.PositiveInfinity;
            int min = 0;
            double minX = 0;
            double minY = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            double min = 0;
            int b = 1;
            for (int i = 0; true; i++)
            {               
                Console.WriteLine("Спортсмен {0}", i + 1);
                double a = Program.GetDouble("Результат | <0 для завершения");
                if (i == 0)
                {
                    min = a;
                    continue;
                }
                if (a < 0)
                {
                    break;
                }
                if (a < min)
                {
                    min = a;
                    b = i + 1;
                }
            }
            Console.WriteLine("{0} спортсмен имеет лучший результат {1}", b, min);
        }
        public static void Task10()
        {
            int n = 0;
            int s = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            int s = 0;
            double a = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
                Console.WriteLine("Ученик {0}", i + 1);
                bool isDunce = false;
                for (int j = 0; j < 4; j++)
                {
                    double mark = Program.GetDouble("оценку от 2 до 5");
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
            int n = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
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
            int n = 0;
            for (int i = 0; true; i++)
            {
                int m = Program.GetCount("Введите -1 для завершения");
                if (m == -1)
                {
                    break;
                }
                n++;
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
