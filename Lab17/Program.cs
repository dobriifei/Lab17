using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер счета");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string fio = Console.ReadLine();
            Console.WriteLine("Укажите баланс");
            int balance = Convert.ToInt32(Console.ReadLine());
            Modelirovanie<int> modelirovanie1 = new Modelirovanie<int>(numInt, fio, balance);
            Console.WriteLine(modelirovanie1.GetInfo());

            Console.WriteLine("Введите строковый номер счета");
            string numString = Console.ReadLine();
            Console.WriteLine("Введите ФИО");
            fio = Console.ReadLine();
            Console.WriteLine("Укажите баланс");
            balance = Convert.ToInt32(Console.ReadLine());
            Modelirovanie<string> modelirovanie2 = new Modelirovanie<string>(numString, fio, balance);
            Console.WriteLine(modelirovanie2.GetInfo());
            Console.ReadKey();
        }
    }
}
