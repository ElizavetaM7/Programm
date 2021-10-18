using System;
namespace Aritheetics
{
    class Programm
    {
        static void Main()
        {
            int n = 2;
            const double g = 9.8;

            Console.WriteLine(n);
            Console.WriteLine(g);
            Console.WriteLine(n++ + ++n);
            Console.WriteLine(n);

            int x = 3, y = 4, z = 5;
            Console.WriteLine(x + y * z);

            x = y += 2;
            Console.WriteLine(x);

            double angle = Math.PI / 6;
            double sinusX = Math.Sin(angle);
            Console.WriteLine(sinusX);

            //int k;
            //k=1;

            var k = "1";
            Console.WriteLine(k);

            angle = x;
            Console.WriteLine(angle);

            x = (int)Math.Pow(2, 3);
            Console.WriteLine(x);

            x = (int)Math.Sqrt(3);
            Console.WriteLine(x);

            x = (int)Math.Round(Math.Sqrt(3));
            Console.WriteLine(x);

            Console.WriteLine((int)(-1.5));
            Console.WriteLine(Math.Floor(-1.5));

            int intengerNumber;
            long longNumber;

            checked
            {
                longNumber = 100;
                integerNumber = (int)longNumber;
                Console.WriteLine(intengerNumber);

                // longNumber = 3000000000L;
                // integerNumber = (int)longNumber
                // Console.WriteLine(integerNumber);
            }
            Console.WriteLine(square(5));
            Console.WriteLine(Square(1.5));

            Console.WriteLine("Введите целое число");
            var val = int.Parse(Console.ReadLine());
            Console.WriteLine(++val);

            var v = 0x91;
            var w = v.ToString();
            Console.WriteLine(w);
            
            w = Convert.ToString(v, 2);
            Console.WriteLine(w);

            int m = 2;
            
            Console.WriteLine(Program.m);


            Console.ReadKey();
        }
        /// <summary> Этот метод возводит в квадрат целое число
        static int Square(int number)
        {
            return number * number;
        }
            
    }
}