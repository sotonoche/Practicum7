using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int count = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите строку: ");
                    str = Console.ReadLine();
                    if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i])) count++;
            }

            Console.WriteLine($"Количество букв в строке = {count}");
        }
    }
}
