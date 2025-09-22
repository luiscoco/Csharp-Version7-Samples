// C# 7.2: stackalloc in more contexts; assign to Span<T>
using System;
class Program
{
    static void Main()
    {
        Span<int> s = stackalloc int[3];
        s[0] = 1; s[1] = 2; s[2] = 3;
        int sum = 0;
        for (int i=0;i<s.Length;i++) sum += s[i];
        Console.WriteLine("sum=" + sum);
    }
}
