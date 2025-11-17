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
        //When have ref in function
        // The output from running the app shows that the value assigned to myVar
        // changes from 20 to 10 after the method call:
        // Before method call myVar = 20
        // After method call myVar = 10
        myVar = 10;
    }

    public void DoSomething(out string myVar)
    {
        //when have out in function
        //The out modifier is generally used to force the method to initialize a
        //variable when it is null at the point it is passed.
        myVar = "Hello out";
    }

    public void DoSomething(in string myVar)
    {
        myVar = "Hello in"; // Syntax error - readonly variable
    }
}
