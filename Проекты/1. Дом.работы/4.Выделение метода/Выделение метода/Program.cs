using System;

namespace Выделение_метода
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Math.Sqrt((1 + Math.Tan(2) * Math.Tan(2) / 3)) +
                       Math.Sqrt((5 + Math.Tan(3) * Math.Tan(2) / 8)) +
                       Math.Sqrt((1 + Math.Tan(5) * Math.Tan(2) / 6));
            Console.WriteLine("x={0}", x);
            Console.ReadLine();
        }
    }
}
