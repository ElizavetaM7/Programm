using System;

namespace ПРЯМОУГОЛЬНИК2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToInt32(Console.ReadLine());
            double S = a * b;
            Console.WriteLine("S= {0}", S);
            

            double P = 2 * (a + b);
            Console.WriteLine("P= {0}", P);

            double D = a * a + b * b;
            double d = Math.Sqrt(D);
            Console.WriteLine("d={0}", d);
            Console.ReadLine();
        }
    }
}
