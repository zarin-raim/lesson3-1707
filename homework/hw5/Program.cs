using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw5
{
    /*
     Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
     Например, если было введено число 345, то программа должна вывести число 543.
         */
    class Program
    {
        static string Reverse(string input)
        {
            char[] str = new char[input.Length];

            for (int i = input.Length -1, j = 0; i >= 0; i--, j++)
            {
               str[j] = input[i];
            }

            string output = string.Join("", str);

            return output;
        }
        static void Main(string[] args)
        {
            int number;
            string strNumber;

            Console.Write("Введите положительное число: ");
            strNumber = Console.ReadLine();

            bool isInt = int.TryParse(strNumber, out number);

            if (isInt && number > 0)
            {
                Console.WriteLine("Обратное число:\t" + Reverse(strNumber));
            }
            else
            {
                Console.WriteLine("Не соответствует условию");
            }
            Console.ReadLine();
        }
    }
}
