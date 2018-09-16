using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("U=  ");
            int.TryParse(Console.ReadLine(), out int U);
            Console.Write("R=  ");
            int.TryParse(Console.ReadLine(), out int R);
            Console.WriteLine("I = {0} \nP = {1}", ((double)U / R).ToString("F"), ((double)U * U / R).ToString("F"));
            Console.ReadKey();
        }
    }
}
