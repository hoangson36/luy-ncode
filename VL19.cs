using System;

namespace baivl19
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var s1 = s.Split(' ');
            int dem = 0;
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            for(int i = b - 1; i > a; i--)
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                    dem++;
                }
            if (dem == 0) Console.Write("NOT FOUND");
        }
    }
}
