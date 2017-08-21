using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw3
{
    /*
     Числовые значения символов нижнего регистра в коде ASCII отличаются от 
     значений символов верхнего регистра на величину 32. Используя эту информацию, 
     написать программу, которая считывает с клавиатуры и конвертирует все 
     символы нижнего регистра в символы верхнего регистра и наоборот.
     */
    class Program
    {
        static void Main(string[] args)
        {
            char[] array;
            string input, output;

            Console.Write("Строка: ");
            input = Console.ReadLine();

            array = input.ToCharArray(0, input.Length);
            for (int i = 0; i < array.Length; i++)
            {
                int symbolCode = (int)array[i];
                if (symbolCode >= 65 && symbolCode <= 90)
                    symbolCode += 32;
                else if (symbolCode >= 97 && symbolCode <= 122)
                    symbolCode -= 32;

                array[i] = (char)symbolCode;
            }

            output = String.Join("", array);
            Console.Write("Результат: " + output);

            Console.ReadLine();
        }
    }
}
