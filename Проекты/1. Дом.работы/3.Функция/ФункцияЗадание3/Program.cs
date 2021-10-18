using System;

namespace ФункцияЗадание3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            string xX = Console.ReadLine();
            double x = Convert.ToDouble(xX);
            double c = x * x; ///Квадрат x
            double O = 1 / c; /// 1/x
            double K = c + O; /// 1 корень
            double S = Math.Sqrt(K); /// извлечение внутреннего корня
            double R = c + S; /// Корень
            double y = Math.Sqrt(R);
            Console.WriteLine("y={0} ", y);
            Console.ReadLine();

        }
    }
}
