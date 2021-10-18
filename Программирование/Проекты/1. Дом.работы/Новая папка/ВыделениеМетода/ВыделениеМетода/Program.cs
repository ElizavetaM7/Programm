using System;

namespace ВыделениеМетода
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Sqrt(x * x + Math.Sqrt(x * x + 1 / x * x));
            Console.WriteLine("Y={0} ", y);
        }
    }
}
