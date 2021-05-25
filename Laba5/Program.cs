using SomeLib;
using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("x + y = {0}", Calc.Sum(x, y));
        }
    }
}
