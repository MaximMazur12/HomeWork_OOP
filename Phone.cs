using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP
{
 public class Phone : Laptop
    {
        public override void TurnONOperatingSystem()
        {
            Console.WriteLine("Starting to work IOS system"); 
        }

        public override void Sum(int a, int b)
        {
            int Sum = 8 + 9;
            Console.WriteLine("$Sum of two numbers is = " + Sum);
        }

        public Phone()
        {
            Name = "Iphone";
            dateRealise = 2015;
        }

        public  float MathOperations(float a, float b, float c, int d)
        {
            return (a - b + c) * d ;
        }
    }
}
