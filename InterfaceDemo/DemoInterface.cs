using System;

namespace InterfaceDemo;

public class DemoInterface : IDemoInterface
{
    public void DemoMethod()
    {
        throw new NotImplementedException();
    }

    //error CS0535: 'DemoInterface' does not implement interface member 'IDemoInterface.DemoMethod1()'
    // public void DemoMethod1()
    // {
    //     Console.WriteLine("Hello from DemoInterface");
    // }
}
