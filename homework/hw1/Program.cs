using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw1
{
    //Написать программу, которая считывает символы с клавиатуры, 
    //пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов.

    class Program
    {
        static void Main(string[] args)
        {
            int countSpaces = 0;
            char temp = ' ';

            while (temp != '.')
            {
                temp = (char)Console.Read();
                if (temp == ' ')
                    countSpaces++;
            }

            Console.WriteLine("Количество введенных пробелов: " + countSpaces);

            Console.ReadLine(); Console.ReadLine();
        }
    }
}
