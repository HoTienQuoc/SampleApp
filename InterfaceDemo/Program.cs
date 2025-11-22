namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDemoInterface demo = new DemoInterface();
            //error CS0535: 'DemoInterface' does not implement interface member 'IDemoInterface.DemoMethod1()'
            // demo.DemoMethod1();

            MyMessageBuilder msgBuilder = new()
            {
                MyMessage = "Interface Demo"
            };
            msgBuilder.ShowMessage();
        }
    }
}