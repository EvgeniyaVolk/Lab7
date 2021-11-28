using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            double S = 0;
            double p = 0;
            double S1= GetParam(x, y, z);
            double S2 = GetParam(x1,y1,z1);
            Console.WriteLine("Площадь треугольника S1={0:f2}", S1);
            Console.WriteLine("Площадь треугольника S2={0:f2}", S2);
            if (S1>S2)
            {
                Console.WriteLine("Площадь S1 больше площади S2");
            }
            else 
            {
                Console.WriteLine("Площадь S2 больше площади S1");
            }
                
            Console.ReadKey();
        }
        static double GetParam(int x, int y, int z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }

}
