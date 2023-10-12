internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter item {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int Longest = 0;
        int cell1=0;
        int cell2=0;
        int tempLongest = 0;
        int tempcell1=0;
        int tempcell2=0;

        for (int i = 0; i < size; i++)
        {
            tempcell1 = i;
            for (int j = 0; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
              
                    tempcell2 = j;
                   int temp = tempcell2 - tempcell1 - 1;
                    if (temp >tempLongest)
                    {
                        tempLongest = temp;
                    }
                }
                
            }
            if (Longest < tempLongest)
            {
                Longest = tempLongest;
                cell1 = tempcell1;
                cell2 = tempcell2;
            }
            tempLongest = 0;
            tempcell1 = 0;  
            tempcell2 = 0;

        }
        Console.WriteLine(Longest);
     
        Console.Write($"cell1: {cell1 + 1} / ");
       
        Console.Write($"cell1: {cell2 + 1}");

    }

}
