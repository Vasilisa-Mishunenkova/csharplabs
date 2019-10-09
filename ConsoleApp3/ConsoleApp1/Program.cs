using System;

namespace лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Введите число x");
            //string x;
            //x = Console.ReadLine();
            //double x1 = Convert.ToDouble(x);

            double x1 = 3.981 / 100;

            //Console.WriteLine("Введите число y");
            //string y;

            //y = Console.ReadLine();
            //double y1 = Convert.ToDouble(y);
            double y1 = -1.625 * 1000;

            //Console.WriteLine("Введите число z");
            //string z;

            //z = Console.ReadLine();
            //double z1 = Convert.ToDouble(z);
            double z1 = 0.512;
            double angle = Math.PI * z1 / 180.0;
            Console.WriteLine("ответ:" + MyFunction(x1, y1, z1));


            static double MyFunction(double x, double y, double z)
            {
                double result;
                result = Math.Pow(2, -x) * Math.Sqrt(x + Math.Pow(Math.Abs(y), 1 / 4)) * Math.Pow((Math.Pow(Math.E, x - 1 / Math.Sin(z))), 1 / 3);
                return result;

            }


        }
    }
}
