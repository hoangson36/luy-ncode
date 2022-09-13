using System;

namespace Vl17
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            n = Math.Abs(n);
            int demuoc = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0) demuoc++;
            Console.WriteLine(demuoc);
        }
    }
}
