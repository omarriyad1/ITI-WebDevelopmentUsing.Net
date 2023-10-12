using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Enter the size of your array: ");
        int size = int.Parse(Console.ReadLine());
        int[] items = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter item {i+1}: ");
            items[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Items:[{string.Join(",", items )}]");
        



    }
}