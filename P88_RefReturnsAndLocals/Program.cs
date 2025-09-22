// C# 7.0: ref returns and ref locals
using System;
class Program
{
    static ref int FindRef(int[] data, int value)
    {
        for (int i = 0; i < data.Length; i++)
            if (data[i] == value) return ref data[i];
        throw new ArgumentException("Not found");
    }

    static void Main()
    {
        int[] arr = {1,2,3};
        ref int loc = ref FindRef(arr, 2);
        loc = 42; // modifies original array
        Console.WriteLine(string.Join(",", arr)); // 1,42,3
    }
}
