using System;

namespace InterfaceDemo;

public class MyMessageBuilder : IMessageBuilder
{
    private string _myMessage = "";
    public string MyMessage
    {
        get => _myMessage;
        set => _myMessage = value;
    }


    public void ShowMessage()
    {
        Console.WriteLine(_myMessage);
    }
}
