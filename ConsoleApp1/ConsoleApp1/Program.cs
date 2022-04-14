using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите улицу");
            string street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            int house = int.Parse(Console.ReadLine());
            Address x = new Address(city, street, house);
            Console.WriteLine("Город: {0} Улица:{1} Дом номер:{2}", x.City, x.Street, x.House);
        }
    }
}
