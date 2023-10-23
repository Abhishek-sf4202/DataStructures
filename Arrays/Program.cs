using System;
class Program{
    public static void Main(string[] args)
    {
    //  Write an algorithm to find a small number from an unsorted integer array in a single pass?
        System.Console.WriteLine("Enter array elements");
        int value = int.Parse(Console.ReadLine());
        int[] array = new int[value];
        System.Console.WriteLine($"Enter {value} numbers");
        for(int i=0;i<value;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int min = array[0];
        for(int i=0;i<value;i++)
        {
            if(min>array[i])
            {
                min = array[i];
            }
        }
        System.Console.WriteLine($"Minimum numbers is {min}");
    }
}