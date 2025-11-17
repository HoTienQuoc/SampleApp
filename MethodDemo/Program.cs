using System;
namespace MethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new();
            demo.SayHello();
            string message = demo.BuildMessage("Bill", 10);
            Console.WriteLine(message);
            demo.BuildMessage(name: "Steve", count: 30);
            demo.BuildMessage(count: 30, name: "Steve");

            message = demo.BuildMessage(count: 30, name: "Steve");
            Console.WriteLine(message);

            List<string> names = ["John", "Paul", "George"];
            demo.GreetGuests(names);
            names = ["Mark", "Robert"];
            demo.GreetGuests(names);


            int myVar = 20;
            Console.WriteLine($"Before method call myVar = {myVar}");
            demo.DoSomething(ref myVar);
            Console.WriteLine($"After method call myVar = {myVar}");

            string myVar1;
            demo.DoSomething(out myVar1);
            Console.WriteLine($"After method call myVar = {myVar1}");
        }
    }
}