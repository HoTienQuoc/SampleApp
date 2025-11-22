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

            //Value type có nghĩa là khi bạn sao chép một biến giá trị, 
            //bạn sao chép toàn bộ dữ liệu của biến đó vào một vị trí bộ nhớ mới.
            SampleStruct myStruct1 = new(name: "Mark");
            SampleStruct myStruct2 = myStruct1;
            //error CS0191: A readonly variable cannot be assigned to (except in a constructor or a variable initializer)
            // myStruct2.Name = "David";
            Console.WriteLine(myStruct1.BuildHelloMsg());
            Console.WriteLine(myStruct2.BuildHelloMsg());



            //Reference value có nghĩa là khi bạn sao chép một biến tham chiếu, 
            //bạn chỉ sao chép con trỏ đến đối tượng trong bộ nhớ chứ không sao chép chính đối tượng đó.
            SampleClass myClass1 = new(name: "Mark");
            SampleClass myClass2 = myClass1;
            myClass2.Name = "David";
            Console.WriteLine(myClass1.BuildHelloMsg());
            Console.WriteLine(myClass2.BuildHelloMsg());
        }
    }
}