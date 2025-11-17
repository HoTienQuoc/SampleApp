using System;
using System.Collections.Generic;

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

    public void GreetGuests(params List<string> guests)
    {
        foreach (var guest in guests)
        {
            Console.WriteLine($"Welcome, {guest}");
        }
    }

    public void DoSomething(ref int myVar)
    {
        myVar = 10;
    }

    public void DoSomething(out string myVar)
    {
        myVar = "Hello";
    }
}
