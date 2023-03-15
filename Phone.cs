using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP
{
 public class Phone : Laptop
    {
        public override void TurnON_OS()
        {
            Console.WriteLine("Starting to work OS - IOS"); 
        }

        public override void Sum(int a, int b)
        {
            int Sum = 8 + 9;
            Console.WriteLine("$Sum of two numbers is = " + Sum);
        }

        public Phone()
        {
            name = "Iphone";
            date_realise = 2015;
        }

        public  float Math_Operations(float a, float b, float c, int d)
        {
            return (a - b + c) * d ;
        }
    }
}
