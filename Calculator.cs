using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSquare
{
    public class Calculator
    {

        public void Triangle()
        {
            Console.WriteLine("Enter");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToInt32(Console.ReadLine());
            
            double p = (a + b + c) / 2;
            double square = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("Площадь треугольника = " + square);
        }

        public void Circle()
        {
            Console.WriteLine("Enter");
            double r = Convert.ToInt32(Console.ReadLine());

            double square = Math.PI * (Math.Pow(r, 2));
            Console.WriteLine("Площадь круга = " + square);
        }
    }
}
