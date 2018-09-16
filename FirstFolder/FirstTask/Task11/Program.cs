using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово:   ");
            string word1 = Console.ReadLine();

            Console.Write("Введите второе слово:   ");
            string word2 = Console.ReadLine();

            Console.Write("Введите третье слово:   ");
            string word3 = Console.ReadLine();

            Console.WriteLine("-" + word1 + "- \n-" + word2 + "- \n-" + word3 + "-");
            Console.ReadKey();
        }
    }
}
