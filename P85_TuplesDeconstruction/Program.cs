// C# 7.0: tuples, tuple return, deconstruction
using System;
class Program
{
    static void Main()
    {
        var t = GetPoint();
        Console.WriteLine($"Tuple: ({t.x},{t.y})");

        var (x, y) = GetPoint(); // deconstruction
        Console.WriteLine($"Deconstructed: {x},{y}");

        // Named tuples
        (int rows, int cols) size = (rows: 10, cols: 20);
        Console.WriteLine($"rows={size.rows}, cols={size.cols}");
    }

    static (int x, int y) GetPoint() => (2, 5);
}
