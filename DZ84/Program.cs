using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ84
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ФИО человека");
            string fio = Console.ReadLine();

            Console.WriteLine("Введите название улицы");
            string streetName = Console.ReadLine();

            Console.WriteLine("Введите номер дома");
            string homeNumber = Console.ReadLine();

            Console.WriteLine("Введите номер квартиры");
            string flatNumber = Console.ReadLine();

            Console.WriteLine("Введите номер мобильного телефона");
            string mobilePhoneNumber = Console.ReadLine();

            Console.WriteLine("Введите номер домашнего телефона");
            string homePhoneNumber = Console.ReadLine();


            XElement myPerson = new XElement("Person");
            XElement myAdress = new XElement("Adress");
            XElement myStreet = new XElement("Street",streetName);
            XElement myHouseNumber = new XElement("HouseNumber", homeNumber);
            XElement myFlatNumber = new XElement("FlatNumber", flatNumber);
            XElement myPhone = new XElement("Phone");
            XElement myMobilePhone = new XElement("MobilePhone", mobilePhoneNumber);
            XElement myFlatPhone = new XElement("FlatPhone", homePhoneNumber);

            XAttribute xAttributeMyPerson = new XAttribute("name", fio);

            myPerson.Add(myAdress, xAttributeMyPerson);
            myAdress.Add(myStreet);
            myAdress.Add(myHouseNumber);
            myAdress.Add(myFlatNumber);
            myPerson.Add(myPhone);
            myPhone.Add(myMobilePhone);
            myPhone.Add(myFlatPhone);

            myPerson.Save("_myPerson.xml");


        }
    }
}
