using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первый катет = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Второй катет = ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("Гипотенуза = {0}", (Math.Sqrt((double)a * a + b*b)).ToString("F"));
            Console.ReadKey();
        }
    }
}
