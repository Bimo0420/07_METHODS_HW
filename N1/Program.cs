using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1 //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона (формула) , где x, y, z – стороны треугольника, p – полупериметр.


{
    internal class Program
    {
        static double GetS(double a, double b, double c)
        {
            double p = (a + b + c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetS(x1, y1, z1);
            Console.WriteLine("Введите стороны первого треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetS(x2, y2, z2);

            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (s2 > s1)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();


        }
    }
}
