internal class Program
{
    public static void print2Darr(int[,] arr, int rows, int columns)
    {
        int numofitems = rows * columns;

        for (int i = 0; i < numofitems; i++)
        {

            // Find row and column index
            int row = i / columns;
            int col = i % columns;
            Console.Write(arr[row, col] + " ");
        }
    }

    private static void Main(string[] args)
    {
            // Given matrix mat[][]
            int[,] mat = { { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 } };
            int N = mat.GetLength(0);
            int M = mat.GetLength(1);
            print2Darr(mat, N, M);
    }
}