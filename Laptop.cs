using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP
{
    public class Laptop : ElectricalDevicesBase
    {
        public override void TurnONOperatingSystem()
        {
            Console.WriteLine("Starting to work Windows operatingSystem");
        }

        public  float MathOperations(float a, float b, float c)  // перегрузка методу з тою ж назвою , але ін параметрами
        {
            return (a + b - c) / 3;
        }


        public override void Sum(int a, int b)  // метод з тою ж сигнаторую що в Базовому, але другою логікою - ПОЛІМОРФІЗМ
        {
            int Sum = a + b;
            Console.WriteLine($"Sum of numbers = " + Sum);
        }


        private int DateRealise;         // властивість з умовою if
        public int daterealise
        {
            get { return DateRealise; }
            set
            {
                if (value < 2007)
                {
                    DateRealise = 2007;
                }
                else
                    DateRealise = value;
            }
        }

        public Laptop(string name)
        {
            this.Name = name;
        }
        public Laptop()            // конструктор з заданими параметрами
        {
            DateRealise = 2002;
            operatingSystem = "Windows";
        }
    }

}
