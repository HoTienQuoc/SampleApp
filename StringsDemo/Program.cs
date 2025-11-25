namespace StringsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String examples would go here
            // string myString;
            // string myString = "Hello World";
            // var myString = "Hello World";
            // string myString = new("Hello World");
            Console.WriteLine("He shouted \"Can you hear me?\"");

            Console.WriteLine(@"You can put a backslash \ here
            and a new line
            and tabs work too.
            You can also put in sequences that would normally be seen as escape
            sequences like \n and \t.");

            string myString = "Hello World";
            Console.WriteLine($"myString length = {myString.Length}");

            Console.WriteLine(myString[0]);
            Console.WriteLine(myString[2]);
            Console.WriteLine(myString[4]);

            // The following line would cause a compile-time error
            // myString[5] = '-';

            char[] charArray = myString.ToCharArray();
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }

            // Concatenating strings
            Console.WriteLine(myString + " How are you?");

            string myString1 = "If at first you don’t succeed, ";
            string myString2 = "try, try again.";
            string myString3 = string.Concat(myString1, myString2);
            Console.WriteLine(myString3);

            // Comparing strings
            if (myString1 == myString2)
            {
                Console.WriteLine("The strings match.");
            }
            else
            {
                Console.WriteLine("They strings not match.");
            }

            if (myString1.Equals(myString2, StringComparison.Ordinal))
            {
                Console.WriteLine("The strings match.");
            }
            else
            {
                Console.WriteLine("The strings do not match.");
            }

            if (string.Equals(myString1, myString2,
StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The strings match.");
            }
            else
            {
                Console.WriteLine("The strings do not match.");
            }

            var result = "My String".Equals("my string", StringComparison.OrdinalIgnoreCase);

            var result1 = string.Compare(myString1, myString2);

            if (result1 == 0)
            {
                Console.WriteLine("Strings match.");
            }
            else if (result1 < 0)

            {
                Console.WriteLine("myString1 precedes myString2 in sort order.");
            }
            else if (result1 > 0)

            {
                Console.WriteLine("myString2 precedes myString1 in sort order.");
            }
            // Changing string case
            string myNewString = "Hello World";
            string newString;
            newString = myNewString.ToUpper();
            Console.WriteLine(newString);
            newString = myNewString.ToLower();
            Console.WriteLine(newString);
            // Splitting a string into multiple parts
            string mySplitString = "Red, Green, Blue, Yellow, Pink, Purple";
            string[] myColors = mySplitString.Split(',');
            foreach (string color in myColors)
            {
                Console.WriteLine(color);
            }
            // Trimming and padding strings
            string myTrimPadString = " hello ";
            Console.WriteLine("[" + myTrimPadString + "]");
            Console.WriteLine("[" + myTrimPadString.Trim() + "]");

            string newTrimPadString;
            newTrimPadString = myTrimPadString.PadLeft(10, ' ');
            newTrimPadString = myTrimPadString.PadRight(20, '*');
            Console.WriteLine("[" + newTrimPadString + "]");

            // String replacement
            string myReplaceString = "Hello World";
            string newReplaceString;
            Console.WriteLine(myReplaceString);
            newReplaceString = myReplaceString.Replace("Hello", "Goodbye");
            Console.WriteLine(newReplaceString);
        }
    }
}