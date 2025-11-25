using System.Collections;
using System.Collections.Generic;

namespace ListCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            // List<string> name = [];
            List<string> colorList = new List<string>();
            // List<string> colorList = [];
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Purple");
            colorList.Add("Orange");

            List<string> colorList_new = ["Red", "Green", "Yellow", "Purple", "Orange"];
            Console.WriteLine(colorList_new[1]);
            Console.WriteLine($"Color before = {colorList_new[2]}");
            colorList_new[2] = "Indigo";
            Console.WriteLine($"Color after = {colorList_new[2]}");
            foreach (string color in colorList_new)
            {
                Console.Write($"{color} ");
            }
            colorList_new.Remove("Orange");
            foreach (string color in colorList_new)
            {
                Console.Write($"{color} ");
            }

            // Sorting lists in C#
            List<string> colorList_sort = ["Red", "Green", "Yellow", "Purple", "Orange"];
            colorList_sort.Sort();
            foreach (string color in colorList_sort)
            {
                Console.Write($"{color} ");
            }

            // Finding items in a C# list
            List<string> colorList_find = ["Red", "Green", "Yellow", "Purple", "Orange"];
            Console.WriteLine(colorList_find.Contains("Green")); // True
            Console.WriteLine(colorList_find.IndexOf("Blue"));  // -1
            Console.WriteLine(colorList_find.LastIndexOf("Purple")); // 3

            // Obtaining information about a list
            List<string> colorList_info = ["Red", "Green", "Yellow", "Purple", "Orange"];
            Console.WriteLine($"Count: {colorList_info.Count}"); // 5
            Console.WriteLine($"Capacity: {colorList_info.Capacity}"); // Capacity may vary
                                                                       // Count: số phần tử thực tế đang có
                                                                       // Capacity: số phần tử tối đa có thể chứa trước khi cần cấp phát thêm bộ nhớ
                                                                       //Capacity ≥ Count: Capacity luôn luôn lớn hơn hoặc bằng Count
            colorList.TrimExcess();// Giảm Capacity xuống bằng với Count

            colorList.Clear();
            Console.WriteLine($"Count = {colorList_info.Count}");
            Console.WriteLine($"Capacity = {colorList_info.Capacity}");

            colorList_info.TrimExcess();

            Console.WriteLine($"Count = {colorList_info.Count}");

            Console.WriteLine($"Capacity = {colorList_info.Capacity}");


        }
    }
}