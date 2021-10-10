using System;

namespace Задание_01
{
    class Program
    {
        /*1.Два треугольника заданы длинами своих сторон.Определить,
         площадь какого из них больше (создать метод для вычисления площади
         треугольника по длинам его сторон).
         Для решения задачи можно использовать формулу Герона
         , где x, y, z – стороны треугольника, p – полупериметр.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны A, B, C первого треугольника:");
            int A1 = Convert.ToInt16(Console.ReadLine());
            int B1 = Convert.ToInt16(Console.ReadLine());
            int C1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Введите стороны A, B, C второго треугольника:");
            int A2 = Convert.ToInt16(Console.ReadLine());
            int B2 = Convert.ToInt16(Console.ReadLine());
            int C2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Площадь первого треугольника составляет: {0:F3}", triangleArea(A1, B1, C1));
            Console.WriteLine("Площадь второго треугольника составляет: {0:F3}", triangleArea(A2, B2, C2));
        }

        //Данный метод возвращает площадь треугольника, вычисленной по формуле Гроона
        static double triangleArea(int a, int b, int c) 
        {
            double semiPerimeter = 0.5 * (a + b + c);
            double square = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return square;
        }
    }
}
