using System;

namespace AbstractDemo;

public class SayHello : Talk
{
    public override void Speak()
    {
        Console.WriteLine("Hello, World!");
    }

    public override void Goodbye()
    {
        base.Goodbye();
        Console.WriteLine("SayHello class says goodbye!");
    }

}
