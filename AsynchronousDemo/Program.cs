using System.Diagnostics;
namespace AsynchronousDemo
{
    internal class Program
    {
        // static void Main(string[] args)
        // {
        //     Stopwatch stopwatch = Stopwatch.StartNew();
        //     Console.WriteLine("\n=== Before async task calls ===\n");
        //     string filename1 = ProcessFile("file1.txt");
        //     Console.WriteLine($"End {filename1} at {DateTime.Now}\n");
        //     string filename2 = ProcessFile("file2.txt");
        //     Console.WriteLine($"End {filename2} at {DateTime.Now}\n");
        //     string filename3 = ProcessFile("file3.txt");
        //     Console.WriteLine($"End {filename3} at {DateTime.Now}\n");
        //     Console.WriteLine("=== After async tasks calls ===\n");
        //     stopwatch.Stop();
        //     TimeSpan timeSpan = stopwatch.Elapsed;
        //     Console.WriteLine($"Elapsed time: {timeSpan.Seconds} seconds");
        // }
        // private static string ProcessFile(string filename)
        // {
        //     Console.WriteLine($"Start {filename} at {DateTime.Now}");
        //     Task.Delay(6000).Wait();
        //     return filename;
        // }

        private static async Task<string> ProcessFileAsync(string filename)
        {
            Console.WriteLine($"Start {filename} at {DateTime.Now}");
            await Task.Delay(6000);
            return filename;
        }

        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("\n=== Before async task calls ===\n");
            // string filename1 = await ProcessFileAsync("file1.txt");
            // Console.WriteLine($"End {filename1} at {DateTime.Now}\n");
            // string filename2 = await ProcessFileAsync("file2.txt");
            // Console.WriteLine($"End {filename2} at {DateTime.Now}\n");
            // string filename3 = await ProcessFileAsync("file3.txt");
            // Console.WriteLine($"End {filename3} at {DateTime.Now}");
            // Console.WriteLine("\n=== After async tasks calls ===\n");
            // stopwatch.Stop();
            // TimeSpan timeSpan = stopwatch.Elapsed;
            // Console.WriteLine($"Elapsed time: {timeSpan.Seconds} seconds\n");

            Task<string> task1 = ProcessFileAsync("file1.txt");
            Task<string> task2 = ProcessFileAsync("file2.txt");
            Task<string> task3 = ProcessFileAsync("file3.txt");

            Console.WriteLine("=== After async tasks calls ===\n");

            // string filename1 = await task1;
            // Console.WriteLine($"End {filename1} at {DateTime.Now}");
            // string filename2 = await task2;
            // Console.WriteLine($"End {filename2} at {DateTime.Now}");
            // string filename3 = await task3;
            // Console.WriteLine($"End {filename3} at {DateTime.Now}\n");
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine($"End {task1.Result} at {DateTime.Now}");
            Console.WriteLine($"End {task2.Result} at {DateTime.Now}");
            Console.WriteLine($"End {task3.Result} at {DateTime.Now}");

            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine($"Elapsed time: {timeSpan.Seconds} seconds");
        }

        private static void SyncMethod()
        {
            await AsyncMethod();
        }
    }
}