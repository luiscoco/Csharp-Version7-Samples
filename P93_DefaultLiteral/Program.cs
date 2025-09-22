// C# 7.1: default literal
using System;
class Program
{
    static void Main()
    {
        int x = default;      // instead of default(int)
        Console.WriteLine(x);
        DateTime dt = default;
        Console.WriteLine(dt);
    }
}
