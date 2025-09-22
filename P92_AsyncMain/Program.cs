// C# 7.1: async Main
using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        await Task.Delay(100);
        Console.WriteLine("Hello from async Main (7.1)");
    }
}
