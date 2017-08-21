using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717_2
{
    class Program
    {
        static int[,] Fill(int[,] array, int rows, int cols, Random rnd)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
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
                    Console.Write(array[i, j] + " ");
                }
                Console.Write('\n');
            }
        }
        static bool InArray(int[] array, int value)
        {
            foreach(int item in array)
                if(value == item)
                    return true;

            return false;
        }
        static int[] Compare(int[,] arrayA, int[,] arrayB, int rows, int cols)
        {
            int[] tmp = new int[rows * cols];
            int i = 0;
            foreach (int itemA in arrayA)
                foreach (int itemB in arrayB)
                    if (itemA == itemB)
                        if (!InArray(tmp, itemB))
                        {
                            tmp[i] = itemB;
                            ++i;
                        }
            int[] result = new int[i];

            for(int k = 0; k < i; k++)
            {
                result[k] = tmp[k];
            }
            return result;
        }


        static void Main(string[] args)
        {
            int rows, cols;
            Random rnd = new Random();

            Console.Write("Введите количество строк: ");
            rows = Int32.Parse(Console.ReadLine());

            Console.Write("Введите количество ячеек: ");
            cols = Int32.Parse(Console.ReadLine());

            int[,] arrayA = new int[rows, cols];
            int[,] arrayB = new int[rows, cols];

            arrayA = Fill(arrayA, rows, cols, rnd);
            arrayB = Fill(arrayB, rows, cols, rnd);

            Console.WriteLine("Массив A");
            Print(arrayA, rows, cols);
            Console.WriteLine("\nМассив B");
            Print(arrayB, rows, cols);

            int[] arrayC = Compare(arrayA, arrayB, rows, cols);

            Console.WriteLine("\nМассив С");
            foreach (int i in arrayC)
                Console.Write(i + " ");
            Console.ReadLine();
        }
    }
}
