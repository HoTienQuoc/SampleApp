using System;

namespace MethodDemo;

public class Demo
{
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }

    public string BuildMessage(string name, int count)
    {
        return ($"Hello {name}, you are visitor number {count}.");
    }
}
