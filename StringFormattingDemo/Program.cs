namespace StringFormattingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string.Format("format string", arg1, arg2, .... );
            string newString;
            newString = string.Format("There are {0} cats in my {1} and no {2}", 2, "house", "dogs");
            Console.WriteLine(newString);
            // Using format controls
            var newFormatString = string.Format("The number {0} in Hexadecimal is {0:X}.", 432);
            Console.WriteLine(newFormatString);
            // C# string Format() format controls
            //C Currency    Định dạng tiền tệ theo locale hiện tại(thêm ký hiệu tiền tệ, ngăn cách hàng nghìn, làm tròn).
            //D Decimal Hiển thị số nguyên thập phân, có thể thêm padding.
            //E Exponential Định dạng theo dạng khoa học(scientific notation), ví dụ 1.23E+05.
            //F Fixed-point Hiển thị số với số chữ số phần thập phân cố định.
            //N Number  Định dạng số “thân thiện” có dấu phẩy và làm tròn.
            //X Hexadecimal Chuyển số sang hệ thập lục phân(hex).
            //0:0…	Zero padding    Thêm số 0 để đủ độ dài.
            //0:0#…	Space padding	Thêm dấu cách khi cần thiết.
            //% Percentage  Nhân giá trị với 100 rồi thêm ký hiệu %.

            var newFormatControlString = string.Format("The number {0} fixed to 2 decimal places is {0:F2}.", 109.78799);
            Console.WriteLine(newFormatControlString);
            newFormatControlString = string.Format("The number {0} using human friendly formatting is {0:N}.", 1023429.78799);
            Console.WriteLine(newFormatControlString);
            newFormatControlString = string.Format("The number {0} using exponential formatting is {0:E6}.", 32423.24232);
            Console.WriteLine(newFormatControlString);
            newFormatControlString = string.Format("The number {0} as a percentage to 3 decinal places is {0:00.000%}.", 0.24232);
            Console.WriteLine(newFormatControlString);
        }
    }
}