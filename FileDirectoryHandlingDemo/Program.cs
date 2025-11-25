namespace FileDirectoryHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the current working directory
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);
            if (Directory.Exists("MyFiles"))
            {
                Console.WriteLine("Directory already exists.");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
            // Create a new directory in the current working directory
            Directory.CreateDirectory("MyFiles");

            DirectoryInfo dirInfo = new("MyFiles");

            if (dirInfo.Exists)
            {
                Console.WriteLine("Directory Exists.");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
                dirInfo.Create();
            }

            // Deleting a Directory
            // Directory.Delete("/Temp/Images");

            // Directory.Delete("/Temp/Images", true);

            // Change the current working directory
            Directory.SetCurrentDirectory("MyFiles");
            Console.WriteLine(Directory.GetCurrentDirectory());

            // Handling File and Directory Exceptions
            try
            {
                Directory.SetCurrentDirectory("MyFiles1");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            // File handling using the File class
            if (File.Exists("/tmp/MyFile.txt"))
            {

            }

            // var myFile = File.Open(, FileMode.);
            // •Append - Opens the file if it exists, or creates a new one if it does not. Subsequent write operations are appended to the existing file content.
            // •Create - Creates a new file, or overwrites it if it already exists.
            // •CreateNew - Attempts to create a new file and throws an exception if
            // the file already exists.
            // •Open - Opens an existing file and throws an exception if it doesn’t exist.
            // •OpenOrCreate - If the file exists it is opened, otherwise a new file is created.
            // •Truncate - Opens an existing file and truncates it to zero length.

            // Reading and writing using the File class
            File.WriteAllText("MyFile.txt", "Hello, this is some text.");
            string content = File.ReadAllText("MyFile.txt");
            Console.WriteLine($"content = {content}");
            File.AppendAllText("MyFile.txt", " This is more text.");
            string content1 = File.ReadAllText("MyFile.txt");
            Console.WriteLine($"content = {content1}");
            List<string> textList = ["Kia Sorento", "Alfa Romeo GTV6", "Chevy Spark", "Ford Explorer", "Toyota Celica"];
            File.WriteAllLines("MyFile.txt", textList);
            string[] readList = File.ReadAllLines("MyFile.txt");
            foreach (string line in readList)
            {
                Console.WriteLine(line);
            }
            // Deleting, copying, and moving files
            File.Delete("/Temp/SomeFile.txt");
            File.Copy("File1.txt", "/Temp/File2.txt");
            File.Move("MyFile.txt", "/Documents/MyFile.txt");
            File.Move("oldfilename.txt", "newfilename.txt");

            // File I/O with streams
            using (StreamWriter writer = new("MyFile.txt"))
            {
                writer.Write('A');
                writer.Write('B');
                writer.Write('C');
                writer.WriteLine("DEFGHIJKLMNOP");
                writer.WriteLine("QRSTUVWXYZ");
            }

            // FileStream Đọc/ ghi byte từ file.
            // StreamReader Đọc chuỗi ký tự(text).
            // StreamWriter Ghi chuỗi ký tự(text).
            // BinaryReader Đọc dữ liệu dạng nhị phân(int, double...).
            // BinaryWriter Ghi dữ liệu dạng nhị phân.

            //Trong C#, Dispose là một phương thức dùng để giải phóng tài nguyên không do GC (Garbage Collector) quản lý, chẳng hạn như:

            using (StreamReader reader = new("MyFile.txt"))
            {

                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                while (reader.Peek() >= 0)
                {
                    Console.WriteLine($"Char = {(char)reader.Read()}");
                }
            }

            // Asynchronous file handling

            // •File.WriteAllLinesAsync()
            // •File.ReadAllLinesAsync()
            // •File.WriteAllTextAsync()
            // •File.ReadAllTextAsync()
            // •StreamReader.ReadAsync()
            // •StreamReader.ReadBlockAsync()
            // •StreamReader.ReadLineAsync()
            // •StreamReader.ReadToEndAsync()
            // •StreamWriter.WriteAsync()
            // •StreamWriter.WriteLineAsync()

            // Working with binary streams
            using (BinaryWriter writer = new(File.Open("Binary.dat",
FileMode.Create)))
            {
                writer.Write("Test data");
                writer.Write(false);
                writer.Write(3.57);
                writer.Write(33);
                writer.Write('W');
            }

            using (StreamReader reader = new("MyFile.txt"))
            {
                char[] charBuffer;
                while (reader.Peek() >= 0)
                {
                    charBuffer = new char[3];
                    reader.Read(charBuffer, 0, 3);
                    Console.WriteLine(charBuffer);
                }
            }

            using (BinaryReader reader = new(File.Open("Binary.dat", FileMode.Open)))
            {
                Console.WriteLine("String = " + reader.ReadString());
                Console.WriteLine("Boolean = " + reader.ReadBoolean());
                Console.WriteLine("Double = " + reader.ReadDouble());
                Console.WriteLine("Int = " + reader.ReadInt32());
                Console.WriteLine("Char = " + reader.ReadChar());
            }
        }
    }
}
