namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] my2Darray = new char[3, 3]
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' },
                { 'G', 'H', 'I' }
            };
            char[,,] my3Darray = new char[2, 2, 3]
            {
                {
                    { 'J', 'K', 'L' },
                    { 'M', 'N', 'O' }
                },
                {
                    { 'P', 'Q', 'R' },
                    { 'S', 'T', 'U' }
                }
            };

            Console.WriteLine($"Dimensions in my2Darray = {my2Darray.Rank}");
            Console.WriteLine($"Dimensions in my3Darray = {my3Darray.Rank}");

            string[] myColors = { "red", "green", "yellow", "orange", "blue" };
            Console.WriteLine($"Element at index 1 = {myColors[1]}");
            myColors[0] = "violet";
            Console.WriteLine($"Element at index 0 = {myColors[0]}");

            char element = my2Darray[0, 0];
            char[,] my2Darray_new = new char[3, 3]
            {
                { 'A', 'B', 'C' },
                { 'D', 'E', 'F' },
                { 'G', 'H', 'I' }
            };
            char[,,] my3Darray_new =
            {
                {
                    { 'J', 'K', 'L' },
                    { 'M', 'N', 'O' }
                },
                {
                    { 'P', 'Q', 'R' },
                    { 'S', 'T', 'U' }
                }
            };
            Console.WriteLine($"{my2Darray_new[0, 0]}");
            Console.WriteLine($"{my2Darray_new[2, 2]}");
            Console.WriteLine($"{my3Darray_new[0, 1, 1]}");
            Console.WriteLine($"{my3Darray_new[1, 1, 2]}");

            string[] myColors_new = ["red", "green", "yellow", "orange", "blue"];
            foreach (string color in myColors_new)
            {
                Console.Write("{0} ", color);
            }

            char[,,] my3Darray_new2 = {
                {
                    { 'J', 'K', 'L' },
                    { 'M', 'N', 'O' }
                },
                {
                    { 'P', 'Q', 'R' },
                    { 'S', 'T', 'U' }
                }
            };
            foreach (char letter in my3Darray_new2)
            {
                Console.Write("{0} ", letter);
            }

            // Working with ranges
            // x..y starts from index x to index y-1
            //.. y starts from index 0 to index y-1
            // x.. starts from index x to the end of the array  
            // x..^y starts from index x+1 to index (length - y - 1)
            // ..^y starts from index 0 to index (length - y - 1)
            //^x.. starts from index x from the end to the end of the array
            string[] sentence = ["The", "best", "way", "to", "predict", "the", "future",
            "is", "to", "invent", "it"];
            string[] words = sentence[4..7];
            string[] new_words = sentence[..5];
            string[] new_1_words = sentence[1..^2];

            string[] subset1 = sentence[^7..^4];
            string[] subset2 = sentence[..^2];
            string[] subset3 = sentence[3..^3];

            foreach (string word in subset1)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine("\n");
            foreach (string word in subset2)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine("\n");
            foreach (string word in subset3)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine("\n");

            string[] myArray = {
                "item 1", // <-- ^7 - 7th from last
                "item 2", // <-- ^6
                "item 3", // <-- ^5
                "item 4", // <-- ^4
                "item 5", // <-- ^3
                "item 6", // <-- ^2
                "item 7" // <-- ^1 - Last item
                // ^0 = array length
            };
            //Sorting C# arrays
            string[] myColors_sort = ["red", "green", "yellow", "orange", "blue"];
            Console.WriteLine("Before Sort");
            foreach (string color in myColors_sort)
            {
                Console.Write("{0} ", color);
            }
            Array.Sort(myColors_sort);
            Console.WriteLine("\n\nAfter Sort");
            foreach (string color in myColors_sort)
            {
                Console.Write("{0} ", color);
            }

            string[] myColors_reverse = ["red", "green", "yellow", "orange", "blue"];
            Array.Reverse(myColors_reverse);
            foreach (string color in myColors_reverse)
            {
                Console.Write("{0} ", color);
            }

            //Clearing C# arrays
            //Array.Clear(, , );
            string[] myColors_clear = ["red", "green", "yellow", "orange", "blue"];
            Array.Clear(myColors_clear, 1, 3);
            foreach (string color in myColors_clear)
            {
                Console.Write("{0} ", color);
            }
        }
    }
}