using System;

namespace bai2
{
        class Program
        {
            static void Main(string[] args)
            {
            string s = Console.ReadLine();
            long n = (long)Convert.ToInt64(s);
            if (nguyento(n))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        static bool nguyento(long m)
        {
            for (int i = 2; i <= Math.Sqrt(m); i++)
                if (m % i == 0) return false;
            return (m >= 2);
        }
        }
    }
