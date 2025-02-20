using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avto
    {
        /// <summary>
        /// Марка автомобиля
        /// </summary>
        private string brand;
        /// <summary>
        /// Цвет Автомобиля
        /// </summary>
        private string color;
        /// <summary>
        /// Скорость автомобиля
        /// </summary>
        private double skor;
        /// <summary>
        /// Конструктор без пармаметров
        /// </summary>
        public Avto(){}
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="brand">Бренд</param>
        public Avto(string brand)
        {
            this.brand = brand;
        }
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="brand">Бренд</param>
        /// <param name="color">Цвет</param>
        public Avto(string brand, string color) : this(brand)
        {
            this.color = color;
        }
        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="brand">Бренд</param>
        /// <param name="color">Цвет</param>
        /// <param name="skor">Скорость</param>
        public Avto(string brand, string color, double skor) : this(brand,color)
        {
            this.skor = skor;
        }
        /// <summary>
        /// Бренд
        /// </summary>
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        } 
        /// <summary>
        /// Цвет
        /// </summary>
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        /// <summary>
        /// Скорость
        /// </summary>
        public double Skor
        {
            get
            {
                return skor;
            }
            set
            {
                if (value < 20)
                    skor = 20;
                else if (value > 120)
                    skor = 120;
                else skor = value;
            }
        }
        /// <summary>
        /// Вывод
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Бренд: {brand}\n Цвет: {color}\n Скорость: {skor}");
        }
        

    }
}
