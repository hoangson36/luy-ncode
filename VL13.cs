using System;
class HelloWorld {
  static void Main() {
    string s = Console.ReadLine();
    int n = Convert.ToInt32(s);
    int tonguoc =0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) tonguoc += i;
            if (tonguoc == n) Console.WriteLine("YES");
            else Console.WriteLine("NO");
  }
}
