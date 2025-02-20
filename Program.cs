using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();
            avto1.Brand = "Toyota";
            avto1.Color = "Красный";
            avto1.Skor = 100;
            avto1.Output();
            Console.WriteLine();

            Avto avto2 = new Avto("Mersedes", "Красный", 60);
            avto2.Output();
            Console.WriteLine();

            Console.Write("Введите марку автомобиля: ");
            string brandInput = Console.ReadLine();
            Console.Write("Введите цвет автомобиля: ");
            string colorInput = Console.ReadLine();
            Console.Write("Введите скорость автомобиля (20-120 км/ч): ");
            int skorInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Бренд: {brandInput}\n Цвет: {colorInput}\n Скорость: {skorInput}");

            Console.Read();
        }
    }
}
