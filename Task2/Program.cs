using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Task1
{
    class Program1
    {
        static void Main()
        {
            int n = 59;  // n символов
            int t = 50;  // t лет
            int s = 200; // пар\сек
            double d = Math.Log(31536000*t*s, n);
            Console.WriteLine("Минимальная длина {0} символов", Math.Round(d));
        }
    }
}
