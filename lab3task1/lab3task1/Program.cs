internal class Program
{
    private static void Main(string[] args)
    {


        void ModifyArrayByValue(int[] array)
        {
            array = new int[] { 100, 200, 300 };
        }

        void ModifyArrayByRef(ref int[] array)
        {
            array = new int[] { 100, 200, 300 };
        }

        int[] numbers = { 1, 2, 3 };

        Console.WriteLine($"Original array: [{string.Join(", ", numbers)}]");

        ModifyArrayByValue(numbers);
        Console.WriteLine($"passing by value: [{string.Join(", ", numbers)}]");

        ModifyArrayByRef(ref numbers);
        Console.WriteLine($"passing by reference: [{string.Join(", ", numbers)}]");

    }
}