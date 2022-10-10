
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        int[] arr = new int[5];
        for (int i = 0; i<arr.Length; i++)
        {
            arr[i] = 5 - (new Random().Next(5)+1);
        }
        List<int> list = new List<int>(arr);
        LinkedList<int> linked = new LinkedList<int>(arr);
        HashSet<int> set = new HashSet<int>(arr);
        SortedSet<int> sorted = new SortedSet<int>(arr);
        foreach (int i in arr)
        {
            Console.Write(i);
        }

        Console.Write("\nlist\n");
        foreach (int i in list)
        {
            Console.Write(i);
        }
         Console.Write("\nlinked\n");
        foreach (int i in linked)
        {
            Console.Write(i);
        }
        Console.Write("\nset\n");
        foreach (int i in set)
        {   
            Console.Write(i);
        }
        Console.Write("\nsorted\n");
        foreach (int i in sorted)
        {
            Console.Write(i);
        }


    }


    public void GenerateNums(List<int> list, int amount, int min, int max)
    {
        for (int i = 0; i < amount; i++)
        {
            Random random = new Random();
            int num = (max+1) - Math.Abs(random.Next(max)+min);
            list.Add(num);
        }
    }
}
