namespace InterfaceDemo;

public interface IDemoInterface
{
    void DemoMethod();

    //error CS0535: 'DemoInterface' does not implement interface member 'IDemoInterface.DemoMethod1()'
    // void DemoMethod1()
    // {
    //     Console.WriteLine("Hello");
    // }
}
