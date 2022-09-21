using System;

namespace Sum3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (double i = 1; i <= n; i++)
            {
                s += 1.0 / (i * (i + 1));

            }
            Console.WriteLine(s.ToString("0.00000"));
        }
    }
}
