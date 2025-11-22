using System;

namespace StructDemo;

public readonly struct SampleStruct(string name)
{
    private readonly string _name = name;
    public readonly string Name
    {
        get => _name;
    }
    public string BuildHelloMsg()
    {
        return "Hello " + _name;
    }
}
