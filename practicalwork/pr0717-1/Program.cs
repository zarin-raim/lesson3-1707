using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717_1
{
    class Program
    {
        static void Print(double[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static double Summ(double[] array)
        {
            double result = 0;
            foreach(var i in array)
            {
                result += i;
            }
            return result;
        }
        static double Multi(double[] array)
        {
            double result = 1;
            foreach (var i in array)
            {
                result *= i;
            }
            return result;
        }
        static double SummEven(double[] array)
        {
            double result = 0;
            for(var i = 0; i < array.Length; i+=2)
            {
                result += array[i];
            }
            return result;
        }

        static double[,] Fill(double[,] array, int rows, int cols)
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }
            return array;
        }
        static void Print(double[,] array, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write('\n');
            }
        }
        static double Max(double[,] array, int rows, int cols)
        {
            int maxR = 0, maxC = 0;
            for (int i = 0; i < rows; i++)
            {               
                for (int j = 1; j < cols; j++)
                {
                    if(array[i, j] > array[maxR, maxC])
                    {
                        maxR = i;
                        maxC = j;
                    }
                }
            }
            return array[maxR, maxC];
        }
        static double Min(double[,] array, int rows, int cols)
        {
            int minR = 0, minC = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] < array[minR, minC])
                    {
                        minR = i;
                        minC = j;
                    }
                }
            }
            return array[minR, minC];
        }
        static double Summ(double [,] array)
        {
            double result = 0;
            foreach (var i in array)
            {
                result += i;
            }
            return result;
        }
        static double Multi(double[,] array)
        {
            double result = 1;
            foreach (var i in array)
            {
                result *= i;
            }
            return result;
        }
        static double SummOddCols(double[,] array, int rows, int cols)
        {
            double result = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 1; j < cols; j += 2)
                {
                    result += array[i, j];
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int sizeA = 5, rowsB = 3, colsB = 4;

            Random rnd = new Random();
            
            double[] arrA = new double[sizeA];
            double[,] arrB = new double[rowsB,colsB];

            Console.WriteLine("Заполнение массива в ручную(5 элементов)");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("[{0}] - ", i);
                int tmp = Int32.Parse(Console.ReadLine());
                arrA[i] = tmp;
            }

            Console.WriteLine("Заполнение массива циклом(3 х 4) ...");
            arrB = Fill(arrB, rowsB, colsB);
            
            Console.Clear();
            Console.WriteLine("Массив А: ");
            Print(arrA);
            Console.WriteLine("\n\nМассив B: ");
            Print(arrB, rowsB, colsB);

            double maxA = arrA.Max();
            double maxB = Max(arrB, rowsB, colsB);

            double minA = arrA.Min();
            double minB = Min(arrB, rowsB, colsB);

            double summaA = Summ(arrA);
            double summaB = Summ(arrB);

            double multiA = Multi(arrA);
            double multiB = Multi(arrB);
            
            Console.WriteLine("\nОбщий максимальный элемент: " + (maxA > maxB ? maxA : maxB));
            Console.WriteLine("Общий минимальный элемент: " + (minA < minB ? minA : minB));
            Console.WriteLine("Общая сумма всех элементов: " + (summaA + summaB));
            Console.WriteLine("Общее произведение всех элементов: " + (multiA * multiB));
            Console.WriteLine("Сумма четных элементов массива А: " + SummEven(arrA));
            Console.WriteLine("Сумма нечетных элементов нечетных столбцов массива B: " + SummOddCols(arrB, rowsB, colsB));

            Console.ReadLine();
        }
    }
}
