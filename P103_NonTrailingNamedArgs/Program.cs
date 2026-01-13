// C# 7.2: non-trailing named arguments
using System;
class Demo
{
    static void F(int a, int b, int c) { Console.WriteLine($"{a},{b},{c}"); }
    static void Main()
    {
        F(a:1, 2, c:3); // name for first, positional for middle, name for last
    }
}
