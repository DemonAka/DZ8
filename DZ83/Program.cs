using System;
using System.Collections.Generic;

namespace DZ83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char key = 'д';
            HashSet<int> hashInt = new HashSet<int>();
            do
            {
                Console.WriteLine("\nВведите число, которое хотите добавить в Hash :");

                int number = Convert.ToInt32(Console.ReadLine());

                if (hashInt.Contains(number))
                {
                    Console.WriteLine("Данное число, уже существует в Hash");
                }
                else
                {
                    hashInt.Add(number);
                    Console.WriteLine($"Число {number} успешно добавлено в коллекцию");
                }

                Console.Write("\nПродожить н/д"); key = Console.ReadKey(true).KeyChar;
            } while (char.ToLower(key) == 'д');
            Console.WriteLine();
            Console.ReadKey();
            foreach (int i in hashInt)
            {
                Console.Write($"{i},");
            }
            Console.ReadKey();
        }
    }
}
