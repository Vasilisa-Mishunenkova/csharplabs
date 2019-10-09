using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Введите число q");
            string q;
            q = Console.ReadLine();
            double q1 = Convert.ToDouble(q);
            Console.WriteLine("Введите число x");
            string x;
            x = Console.ReadLine();
            double x1 = Convert.ToDouble(x);
            double result;
            result = 0;
            if (x1 * q1> 10)
            { 
            result=Math.Log(Math.Abs((Math.Pow(Math.E, x1)) + Math.Abs(q1)));
            
            }

            if (x1 * q1 < 10)
            {
                result = Math.Pow(Math.E, q1);
            }
            if (x1 * q1 == 10)
            {
                result = Math.Pow(Math.E, x1) + q1;
            }
            Console.WriteLine(result);
}
}
}
