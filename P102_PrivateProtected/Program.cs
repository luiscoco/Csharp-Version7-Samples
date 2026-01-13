// C# 7.2: private protected access
using System;
class Base
{
    private protected int Secret = 42; // accessible only within containing class or derived classes in same assembly
}
class Derived : Base
{
    public void Show() { Console.WriteLine(Secret); }
}
class Program
{
    static void Main()
    {
        var d = new Derived();
        d.Show();
    }
}
