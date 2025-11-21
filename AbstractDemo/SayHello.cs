using System;

namespace AbstractDemo;

public class SayHello : Talk
{
    public override void Speak()
    {
        Console.WriteLine("Hello, World!");
    }


}
