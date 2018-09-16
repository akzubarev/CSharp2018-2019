using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number from 32 to 128:   ");

            int.TryParse(Console.ReadLine(), out int code);
            Console.Write("Symbol is:  " + (char)code);
            Console.ReadKey();
        }
    }
}
