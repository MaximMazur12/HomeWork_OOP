using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP
{


    public class Laptop : Electrical_Devices
    {
        public override void TurnON_OS()
        {
            Console.WriteLine("To Turn on of Laptop OS");
        }

        public  float Math_Operations(float a, float b, float c)  // перегрузка методу з тою ж назвою , але ін параметрами
        {
            return (a + b - c) / 3;
        }


        public override void Sum(int a, int b)  // метод з тою ж сигнаторую що в Базовому, але другою логікою - ПОЛІМОРФІЗМ
        {
            int _sum = a + b;
            Console.WriteLine($"Sum of numbers = " + _sum);
        }


        private int _DateRealise;         // властивість з умовою if
        public int date_realise
        {
            get { return _DateRealise; }
            set
            {
                if (value < 2007)
                {
                    _DateRealise = 2007;
                }
                else
                    _DateRealise = value;
            }
        }

        public Laptop(string name)
        {
            this.name = name;
        }
        public Laptop()            // конструктор з заданими параметрами
        {
            date_realise = 2002;
            OS = "Windows";
        }
    }

}
