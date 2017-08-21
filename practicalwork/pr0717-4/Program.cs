using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string str = Console.ReadLine();

            string[] array = str.Split(' ');

            Console.WriteLine("Колличество слов: " + array.Length);

            Console.ReadLine();
        }
    }
}
