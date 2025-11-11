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

    public void DoSomething(int myVar)
    {
        myVar = 10;
    }
}
