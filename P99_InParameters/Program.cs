// C# 7.2: in parameters (readonly by ref)
using System;
struct Big
{
    public int A, B, C, D;
    public override string ToString(){ return A + "," + B + "," + C + "," + D; }
}
class Program
{
    static int Sum(in Big v) // passed by readonly reference
    {
        // v.A = 1; // compile error: cannot assign to variable passed with in
        return v.A + v.B + v.C + v.D;
    }
    static void Main()
    {
        var b = new Big { A=1,B=2,C=3,D=4 };
        Console.WriteLine(Sum(in b));
    }
}
