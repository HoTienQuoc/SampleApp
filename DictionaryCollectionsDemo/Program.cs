namespace DictionaryCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, string> name = new Dictionary<string, string>();
            // Dictionary<string, string> movies =
            // new Dictionary<string, string>();
            // var movies = new Dictionary<string, string>();
            // var name = new Dictionary()<TKey, TValue>
            // {
            // { key1, value1 },
            // { key2, value2 },
            // { key3, value3 },
            // .
            // .
            // };

            var movies = new Dictionary<string, string>()
            {
                { "DRA-1212", "The Godfather" },
                { "WAR-4433", "Apocalypse Now" },
                { "COM-5465", "The Terminal" },
                { "CLA-1659", "Casablanca" }
            };
            Console.WriteLine($"Count = {movies.Count}");

            foreach (var movie in movies)
            {
                var key = movie.Key;
                var value = movie.Value;
                Console.WriteLine($"{key} - {value}");
            }

            movies.Add("SCI-2323", "Prometheus");
            Console.WriteLine(movies["SCI-2323"]);
            movies.Remove("WAR-4433");
            foreach (var movie in movies)
            {
                var key = movie.Key;
                var value = movie.Value;
                Console.WriteLine($"{key} - {value}");
            }
            // Accessing and updating dictionary items
            Console.WriteLine(movies["COM-5465"]);
            movies["COM-5465"] = "Caddyshack";
            Console.WriteLine(movies["COM-5465"]);
            if (movies.ContainsKey("CLA-1659"))
            {
                Console.WriteLine("Key exists in dictionary");
            }
            if (movies.ContainsValue("The Godfather"))
            {
                Console.WriteLine("Value exists in dictionary");
            }
        }
    }
}