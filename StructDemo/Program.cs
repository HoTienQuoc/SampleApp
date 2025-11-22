namespace StructDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleStruct demoStruct = new(name: "Alex");
            SampleClass demoClass = new(name: "Anna");
            Console.WriteLine(demoStruct.BuildHelloMsg());
            Console.WriteLine(demoClass.BuildHelloMsg());
        }
    }
}