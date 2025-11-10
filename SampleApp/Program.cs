using System;
namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var username = Console.ReadLine();
            Console.WriteLine($"Hi {username}. Welcome to C#!");
            
        }
    }
}