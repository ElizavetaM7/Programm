using System;

namespace СинусКосинус
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = Math.Round(Math.Cos(15*Math.PI/180),3);
            double z = Math.Round(Math.Cos(37*Math.PI/180),3);
            double y = Math.Round(Math.Cos(113*Math.PI/180),3);
            
            double xS = Math.Round(Math.Sin(15 * Math.PI / 180), 3);
            double zS = Math.Round(Math.Sin(37 * Math.PI / 180), 3);
            double yS = Math.Round(Math.Sin(113 * Math.PI / 180),3);
            Console.ReadLine();

            
            Console.WriteLine(Math.Round(Math.Sin(p * Math.PI / 180), 3));
            Console.WriteLine(Math.Round(Math.Cos(p * Math.PI / 180), 3));
            Console.ReadLine();


            Console.WriteLine("Cos 15={0}", x);
            Console.WriteLine("Cos 37={0}", z);
            Console.WriteLine("Cos 113={0}", y);;
            Console.WriteLine("Sin 15={0}", xS);
            Console.WriteLine("Sin 37={0}", zS);
            Console.WriteLine("Sin 113={0}", yS);
            Console.ReadLine();





        }
    }
}
