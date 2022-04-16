using System;

namespace SubtractionWithoutUsingTheMinusOperator
{
    internal class Program
    {
        private static int Subtract(int x, int y)
        {
            if (y == 0)
                return x;

            return Subtract(x ^ y, (~x & y) << 1);
        }
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            Console.Write("1.Number =>");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Number =>");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} - {y} = {Subtract(x, y)}");
            Console.ReadLine();
        }
    }
}
