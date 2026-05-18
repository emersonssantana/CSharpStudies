using System;

namespace CSharpStudies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2026, 5, 18, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

        }
    }
}


    