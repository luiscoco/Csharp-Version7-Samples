// C# 7.0: pattern matching (is / switch) with type/constant patterns and when guards
using System;
class Program
{
    static void Print(object o)
    {
        if (o is int i && i > 0)
            Console.WriteLine($"positive int: {i}");
        else if (o is string s && s.Length > 0)
            Console.WriteLine($"non-empty string: {s}");
        else
            Console.WriteLine("other");

        switch (o)
        {
            case null:
                Console.WriteLine("null");
                break;
            case int n when n % 2 == 0:
                Console.WriteLine($"even int: {n}");
                break;
            case string str when str.Contains("hi"):
                Console.WriteLine($"greeting: {str}");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }

    static void Main()
    {
        Print(4);
        Print("hi there");
        Print(-3);
        Print(null);
    }
}
