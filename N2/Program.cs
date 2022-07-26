using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    internal class Program
    {
        static void GetVSCube (double a, out double s, out double v)
        {
            v = a * a * a;
            s = a * a * 6;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            double A = Convert.ToDouble(Console.ReadLine());
            double V;
            double S;
            GetVSCube (A, out V, out S);
            Console.WriteLine("{0:0.00} {1:0.00}", S, V);
            Console.ReadLine();
        }
    }
}
