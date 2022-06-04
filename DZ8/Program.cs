using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ81
{
    

    internal class Program
    {

        static List<int> RandomList()
        {
            List<int> intList = new List<int>();
            Random rng = new Random();
            int check = 0;
            do
            {
                intList.Add(rng.Next(0, 100));
                check++;
            } while (check < 100);
            //for (int i = 0; i < 100; i++)
            //{
            //    intList.Add(rng.Next(0,100));
            //}
            return intList;
        }
      
        static void PrintList(List<int> example)
        {
            List<int> intList = example;
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]},");
            }
        }



        static void DeleteNumbers(List<int> example)
        {
            List<int> intList = example;
            intList.RemoveAll(x => x < 25 || x > 50);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{intList[i]},");
            }

        }

        static void Main(string[] args)
        {
            List<int> intList = RandomList();

            PrintList(intList);
            Console.ReadKey();
            Console.WriteLine("\nА теперь удаляем все числа вне диапазона (25,50)");
            DeleteNumbers(intList);
            Console.ReadKey();

        }
    }
}


