using System;
namespace SUMDIG
{
class Program {
  static void Main(string[] args) 
  {
  int t= Convert.ToInt32(Console.ReadLine());
  long[] mang= new long[100002];
  int t1=t;
  while(t>0)
  {
      mang[t]=Convert.ToInt64(Console.ReadLine());
      t--;
  }
  while(t1>0)
  {
    Console.WriteLine("{0}", sumdig(mang[t1]));
    t1--;
  }
  Console.ReadLine();
}
static long sumdig(long x)
{
    long sum = 0 ;
    while(x>0)
    {
        sum= sum+x%10;
        x=x/10;
        
    }
    return sum;
}
}
}
