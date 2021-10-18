using System;

namespace StringTasks
{
    class Program
    {
        static void Main();
        {
            Console.WriteLine(GetHalfString("Hello, world"));

            Console.ReadKey();
        }

    static string GethalfString(string fullString)
         {
        var s = FullHalfString.Replace(" ", "");
        return s.Substring(s.Leght / 2);
         }
    }
}