using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw2
{

    /*
     Ввести с клавиатуры номер трамвайного билета (6-значное число) 
     и про-верить является ли данный билет 
     счастливым (если на билете напечатано шестизначное число, 
     и сумма первых трёх цифр равна сумме 
     последних трёх, то этот билет считается счастливым).
         */
    class Program
    {
        static void Main(string[] args)
        {
            int length = 6, number;

            Console.Write("Введите номер билета: ");
            string temp = Console.ReadLine();

            bool isInt = int.TryParse(temp, out number);
            
            if(isInt && temp.Length == length)
            {
                int half1 = number / 1000;
                int half2 = number % 1000;

                int digit1 = half1 / 100;
                int digit2 = (half1 / 10) % 10;
                int digit3 = half1 % 10;

                int summHalf1 = digit1 + digit2 + digit3;

                int digit4 = half2 / 100;
                int digit5 = (half2 / 10) % 10;
                int digit6 = half2 % 10;
                
                int summHalf2 = digit4 + digit5 + digit6;

                if(summHalf1 == summHalf2)
                    Console.WriteLine("Поздравляем! Билет счастливый!");
                else
                    Console.WriteLine("Повезет в другой раз :(");

            }
            else
            {
                Console.WriteLine("Введенное число не соответсвует виду номера трамвайного билета");
            }

            Console.ReadLine();
        }
    }
}
