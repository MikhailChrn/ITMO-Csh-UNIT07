using System;

namespace Задание_02
{
    class Program
    {
        //2.Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба [мм]:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            cubeParamPrint(A);
            Console.ReadKey();
        }

        static void cubeParamPrint(double a) //Процедура выводит на консоль объём и площадь куба
        {
            Console.WriteLine("Объём данного куба составляет: {0:F2} [куб.мм]", Math.Pow(a, 3));
            Console.WriteLine("Площадь поверхности данного куба составляет: {0:F2} [кв.мм]", 6 * Math.Pow(a, 2));

        }
    }
}
