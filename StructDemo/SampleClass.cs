using System;

namespace StructDemo;

public class SampleClass(string name)
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
