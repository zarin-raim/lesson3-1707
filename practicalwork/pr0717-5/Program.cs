using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717_5
{
    class Program
    {
        static int[,] Fill(int[,] array, int rows, int cols, Random rnd)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                }
            }
            return array;
        }
        static void Print(int[,] array, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write('\n');
            }
        }
        static int Summ(int[,] array, int minR, int minC, int maxR, int maxC, int cols)
        {
            int startR, startC, endR, endC;
            startR = startC = endR = endC = 0;

            if (minR < maxR || (minR == maxR && minC < maxC))
            {
                startR = minR;
                startC = minC;
                endR = maxR;
                endC = maxC;
            }
            else if (minR > maxR || (minR == maxR && minC > maxC))
            {
                startR = maxR;
                startC = maxC;
                endR = minR;
                endC = minC;
            }

            int result = 0;

            int end = startR == endR ? endC : cols;
            for (int i = startC; i < end; i++)
            {               
                result += array[startR, i];
                Console.Write(array[startR, i] + "  ");
            }

            for (int i = startR + 1; i < endR; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += array[i, j];
                    Console.Write(array[i, j] + "  ");
                }
            }

            for (int i = 0; i < endC; i++)
            {
                result += array[endR, i];
                Console.Write(array[endR, i] + "  ");
            }               

            return result;

        }

        static void Main(string[] args)
        {
            int rows = 5, cols = 5;
            int[,] array = new int[rows, cols];

            Random rnd = new Random();

            array = Fill(array, rows, cols, rnd);
            Print(array, rows, cols);

            int maxR = 0, maxC = 0, minR = 0, minC = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] > array[maxR, maxC])
                    {
                        maxR = i;
                        maxC = j;
                    }
                    if (array[i, j] < array[minR, minC])
                    {
                        minR = i;
                        minC = j;
                    }
                }
            }
            int summa = Summ(array, minR, minC, maxR, maxC, cols);
            Console.WriteLine("Сумма элементов между минимальным и максимальным значениями: " + summa);

            Console.ReadLine();
        }
    }
}
