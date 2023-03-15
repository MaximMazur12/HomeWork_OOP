using HomeWork_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



var laptop1 = new Laptop();
laptop1.date_realise = 1999;       // тут перевірка властивості з умовою
Console.WriteLine($"date realise MacBook is " + laptop1.date_realise);
laptop1.TurnON_OS();               // визов абстрактного методу
laptop1.Sum(4, 8);                 // визов методу з передачею параметрів

var Phone = new Phone();
Phone.date_realise = 2010;
Console.WriteLine($"date realise Iphone is" + Phone.date_realise);
Phone.TurnON_OS();


namespace HomeWork_OOP
{
    public abstract class Electrical_Devices
    {
        private decimal price { get; }
        protected string name { get; set; }
        public int date_realise;
        protected int weight;
        protected string OS;               // Protected поле OS треба для того щоб було видно в насліднику

        public virtual void Sum(int a, int b)      // БАЗОВИЙ метод VIRTUAL
        {
            int _sum = a + b;
        }

        public float Math_Operations(float a, float b)   // перегрузка методів - одна назва, різні параметри
        {
            return a + b;
        }

        public abstract void TurnON_OS();    // ABSTRACT метод , який треба реалізувати в наслідниках
    }
}
