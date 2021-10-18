using System;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Console.WriteLine("Задача 3");
            ///Console.WriteLine("адрес эл. почты");
            ///var email = Console.ReadLine();
            ///var index = email.IndexOf('@');
            ///var mailBox = email.Substring(0, index);
            ///var mailService = email.Substring(index +1);
            ///Console.WriteLine($"Ваш почтовый ящик {mailBox} находится на почтовом сервисе {mailService}");


            ///Console.WriteLine("Задача 3+");
            ///Console.WriteLine("адрес эл. почты");
            ///email = Console.ReadLine();
            ///var strings = email.Split(new[] { '@' });
            ///Console.WriteLine($"Ваш почтовый ящик {strings[0]} находится на почтовом сервисе {strings[1]}");


            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите символ");
            var simvol = Console.ReadLine()[0];
            Console.WriteLine($"Символ \'{ simvol}\':0x{Convert.ToString((int)simvol, 16)}");
            Console.WriteLine($"Следующий символ: \'{(char)((int)simvol + 1)}\'");


            Console.WriteLine("Задача 4+");
            Console.WriteLine("Введите символ");
            var simvol2 = Console.ReadKey().KeyChar;
            Console.WriteLine($"Символ \'{ simvol2}\':0x{Convert.ToString((int)simvol2, 16)}");
            Console.WriteLine($"Следующий символ: \'{(char)((int)simvol2 + 1)}\'");

        }
    }
}
