using System;

namespace C_SHARP_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Hello World!");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("x cube is:{0}", computeCube(x));
        }
        static int computeCube(int x)
        {
            return x * x * x;
        }
    }
}
