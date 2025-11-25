namespace Jagged_2D_3D_Arrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type[] arrayname;
            // Declaring single dimensional arrays
            string[] myColors;
            myColors = ["red", "green", "yellow", "orange", "blue"];
            string[] myColors1 = ["red", "green", "yellow", "orange", "blue"];
            string[] myColors2 = new string[5];
            string[] myColors3 = new string[5] { "red", "green", "yellow", "orange", "blue" };

            // Declaring multidimensional arrays
            // char[,] my2Darray;
            char[,] my2Darray =
            {
                {'a', 'b', 'c'},
                {'c', 'd', 'e'},
                {'c', 'd', 'e'}
            };

            char[,] my2Darray2 = new char[3, 3]
            {
                {'a', 'b', 'c'},
                {'c', 'd', 'e'},
                {'c', 'd', 'e'}
            };

            char[,,] my3Darray =
            {
                {
                    { 'a', 'b', 'c' },
                    { 'c', 'd', 'e' }
                },
                {
                    { 'f', 'g', 'h' },
                    { 'i', 'j', 'k' }
                }
            };

            char[,,] my3Darray2 = new char[2, 2, 3]
            {
                {
                    { 'a', 'b', 'c' },
                    { 'c', 'd', 'e' }
                },
                {
                    { 'f', 'g', 'h' },
                    { 'i', 'j', 'k' }
                }
            };

            // Declaring jagged arrays
            // type[][] arrayname;
            // char[][] myJaggedArray;
            char[][] myJaggedArray = [
                ['a', 'b', 'c', 'd', 'e'],
                ['f', 'g', 'h', 'i'],
                ['j', 'j'],
                ['k', 'l', 'm', 'n', 'o', 'p', 'q', 'r']
            ];
        }
    }
}