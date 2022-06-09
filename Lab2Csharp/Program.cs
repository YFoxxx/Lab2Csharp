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
            int n = 59; //n - символов
            int k = 5;  //k - длина пароля
            int s = 200;//s - скорость преребора пароля s/sec
            double C = (Math.Pow(n, k)/s)/86400;
            Console.WriteLine("{0} день", Math.Round(C, 2));
        }
    }
}