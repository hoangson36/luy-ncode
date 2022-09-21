using System;

namespace vt16
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = UInt64.Parse(Console.ReadLine());
            ulong s = 0;
            for(ulong i = 1; i <= n; i++)
            {
                s = s + i * i;

            }
            Console.WriteLine("{0} ",s);
        }
    }
}
