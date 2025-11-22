using System;

namespace InterfaceDemo;

public class MyMessageBuilder : IMessageBuilder
{
    private string _myMessage = "";
    string myMessage; // Fields are invalid in interfaces

    string MyMessage { get; set; }
    public void ShowMessage()
    {
        throw new NotImplementedException();
    }
}
