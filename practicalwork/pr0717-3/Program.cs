using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717_3
{
    class Program
    {
        static bool Polindrom(string str)
        {
            str = str.ToLower();
            for (int i = 0,j = str.Length - 1; i < j; i++, j--){
                if (str[i] != str[j])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            if (Polindrom(str))
                Console.WriteLine("Строка является полиндромом!");
            else
                Console.WriteLine("Строка НЕ является полиндромом!");


            Console.ReadLine();
        }
    }
}
