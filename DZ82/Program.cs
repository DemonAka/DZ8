using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ82
{
    internal class Program
    {
        
        static Dictionary<string, string> AddPhone ()
        {
            char key = 'д';
            Dictionary<string, string> phoneNumber = new Dictionary<string, string>();

            do
            {
                Console.WriteLine("\nВведите номер телефона :");
                string phone = Console.ReadLine();
                Console.WriteLine("Введите ФИО:");
                string fio = Console.ReadLine();
                phoneNumber.Add(phone, fio);

                Console.Write("\nПродожить н/д"); key = Console.ReadKey(true).KeyChar;
            } while (char.ToLower(key) == 'д');
            return phoneNumber;
        }

        static void PrintDictionary(Dictionary<string, string> phoneNumber)
        {
            foreach (KeyValuePair<string, string> e in phoneNumber) Console.WriteLine($"\n{e} ");
        }

        static void SerchPhone (Dictionary<string, string> phoneNumber)
        {
            Console.WriteLine("Введите номер телефона, который вы хотите найти:");
            string findPhone = Console.ReadLine();
            string valuePhone = "";
            

            
            if(phoneNumber.TryGetValue(findPhone, out valuePhone))
            {
                Console.WriteLine($"Номер телефона: {findPhone} ФИО: {valuePhone}");
            }
            else
            {
                Console.WriteLine("Данного номера не существует");
            }

            //int count = 0;
            //foreach (var e in phoneNumber)
            //{
            //    if (e.Key == findPhone)
            //    {
            //        Console.WriteLine($"\n Номер телефона: {e.Key}  ФИО : {e.Value}");
            //        count++;
            //    }
            //}
            //if (count == 0) { Console.WriteLine("Данного номера не существует"); }
        }
        
        static void Main(string[] args)
        {
            
            Dictionary<string, string> phoneNumber = AddPhone();
            //PrintDictionary(phoneNumber);
            Console.ReadKey();
            SerchPhone(phoneNumber);
            Console.ReadKey();

        }
    }
}
