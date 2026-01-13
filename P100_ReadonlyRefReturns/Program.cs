// C# 7.2: ref readonly returns
using System;
class Program
{
    static readonly int[] data = { 3, 1, 4 };
    static ref readonly int MaxRef()
    {
        int maxIndex = 0;
        for (int i=1;i<data.Length;i++) if (data[i] > data[maxIndex]) maxIndex=i;
        return ref data[maxIndex];
    }

    static void Main()
    {
        ref readonly int r = ref MaxRef();
        Console.WriteLine(r);
        // r = 10; // compile error: read-only
    }
}
