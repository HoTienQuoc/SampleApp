using System;

namespace AbstractDemo;

public abstract class Talk
{
    public abstract void Speak();
    public virtual void Goodbye()
    {
        Console.WriteLine("Goodbye!");
    }
}
