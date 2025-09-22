// C# 7.0: binary literals & digit separators
using System;
class Program
{
    static void Main()
    {
        int mask = 0b_1010_0001;
        long big = 1_000_000_000;
        Console.WriteLine($"mask={mask}, big={big}");
    }
}
