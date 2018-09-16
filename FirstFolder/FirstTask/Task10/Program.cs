using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
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

            Console.WriteLine(word1 + "!" + word2 + "!" + word3);
            Console.ReadKey();
        }
    }
}
