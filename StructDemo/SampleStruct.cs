using System;

namespace StructDemo;

public struct SampleStruct(string name)
{
    private string _name = name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public string BuildHelloMsg()
    {
        return "Hello " + _name;
    }
}
