using HomeWork_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



var laptop1 = new Laptop();
laptop1.dateRealise = 1999;       // тут перевірка властивості з умовою
Console.WriteLine($"date realise MacBook is " + laptop1.dateRealise);
laptop1.TurnONOperatingSystem();               // визов абстрактного методу
laptop1.Sum(4, 8);                 // визов методу з передачею параметрів

var Phone = new Phone();
Phone.dateRealise = 2010;
Console.WriteLine($"date realise Iphone is" + Phone.dateRealise);
Phone.TurnONOperatingSystem();

namespace HomeWork_OOP
{
    public abstract class ElectricalDevicesBase
    {
        private decimal Price { get; }
        protected string Name { get; set; }
        public int dateRealise;
        protected int weight;
        protected string operatingSystem;               // Protected поле operatingSystem треба для того щоб було видно в насліднику

        public virtual void Sum(int a, int b)      // БАЗОВИЙ метод VIRTUAL
        {
            int Sum = a + b;
        }

        public float MathOperations(float a, float b)   // перегрузка методів - одна назва, різні параметри
        {
            return a + b;
        }

        public abstract void TurnONOperatingSystem();    // ABSTRACT метод , який треба реалізувати в наслідниках
    }
}
