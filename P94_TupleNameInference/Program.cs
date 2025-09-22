// C# 7.1: tuple element name inference
using System;
class Program
{
    static void Main()
    {
        int width = 10, height = 20;
        var rect = (width, height); // names inferred
        Console.WriteLine($"{rect.width} x {rect.height}");
    }
}
