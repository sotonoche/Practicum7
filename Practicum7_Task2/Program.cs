using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practicum7_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, chr;

            while (true)
            {
                try
                {
                    Console.Write("Введите строку: ");
                    str = Console.ReadLine();
                    Console.Write("Введите символ, на который заканчивается слово: ");
                    chr = Console.ReadLine();
                    if (str.Length == 0 || chr.Length == 0) throw new Exception("Строка не должна быть пустой!");
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            List<string> list = new List<string>(str.Split('\u002C', ' '));
            
            m1:
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].EndsWith(chr))
                {
                    list.RemoveAt(i);
                    goto m1;
                }
            }

            Console.Write("Обработанная строка: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
