using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParams(a, out S, out V);
            Console.WriteLine("Площадь = {0}", S);
            Console.WriteLine("Объем = {0}", V);
            Console.ReadKey();
        }
        static void GetParams(double a, out double S, out double V)
        {
            S = Math.Pow(a, 2) * 6;
            V = Math.Pow(a, 3);
         }
    }
}
