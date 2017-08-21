using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr0717
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            string name = "Zarina";
            double salary = 5000000000000000.0;

            Console.WriteLine("Вас зовут " + name + "; Ваш возвраст " + age + "; Ваша зп" + salary);

            Console.WriteLine("Вас зовут {0}; Ваш возвраст {1}; Ваша зп {2}", name, age, salary);

            string fullInfo = String.Format("Вас зовут {0}; Ваш возвраст {1}; Ваша зп {2}", name, age, salary);
            string path = @"C:\Data\info.txt";

            Console.ReadLine(); 
        }
    }
}
