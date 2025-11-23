namespace TupleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetProductData();
            var (count, product, price) = GetProductData1();
            Console.WriteLine($"Price = {price}");
            Console.WriteLine($"Product = {product}");
            Console.WriteLine($"Quantity = {count}");
        }
        private static void GetProductData()
        {
            var myTuple = (10, "Refrigerator", 432.43);
            // 10: Item1
            // "Refrigerator": Item2
            // 432.43: Item3
            var item2 = myTuple.Item2;
            Console.WriteLine(item2);

            var myTuple1 = (Count: 10, Product: "Refrigerator", Price: 432.43);
            Console.WriteLine($"myTuple1 Price = {myTuple1.Price}");
            Console.WriteLine($"myTuple1 Product = {myTuple1.Product}");
            Console.WriteLine($"myTuple1 Quantity = {myTuple1.Count}");

            Console.WriteLine($"GetProductData1: {GetProductData1()}");


            var myTuple2 = GetProductData1();
            Console.WriteLine($"myTuple Price = {myTuple.Item1}");
            Console.WriteLine($"myTuple Product = {myTuple.Item2}");
            Console.WriteLine($"myTuple Quantity = {myTuple.Item3}");


            (int Count, string Product, double Price) myTuple3 = GetProductData1();
            Console.WriteLine($"myTuple Price = {myTuple3.Price}");
            Console.WriteLine($"myTuple Product = {myTuple3.Product}");
            Console.WriteLine($"myTuple Quantity = {myTuple3.Count}");



            DisplayProductData((20, "Water filter", 29.99));
            var myTuple4 = (20, "Water filter", 29.99);
            DisplayProductData(myTuple4);
        }

        private static (int, string, double) GetProductData1()
        {
            var myTuple = (Count: 10, Product: "Refrigerator", Price: 432.43);
            return myTuple;
            // return (10, "Refrigerator", 432.43);
        }

        public static void DisplayProductData((int, string, double) productTuple)
        {
            var (count, product, price) = productTuple;
            Console.WriteLine($"Price = {price}");
            Console.WriteLine($"Product = {product}");
            Console.WriteLine($"Quantity = {count}");
        }
    }
}