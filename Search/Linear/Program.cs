using System;
namespace Search{
    class Program{
        public static void Main(string[] args)
        {
             System.Console.WriteLine("Enter array elements");
        int value = int.Parse(Console.ReadLine());
        int[] array = new int[value];
        System.Console.WriteLine($"Enter {value} numbers");
        for(int i=0;i<value;i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Enter the search Element");
        int search  = int.Parse(Console.ReadLine());
        bool check = true;
        for(int i=0;i<value;i++)
        {
            if(search == array[i])
            {
                check = false;
                break;
            }
        }
        if(check)
        {
            System.Console.WriteLine("Element not present in the list");
        }
        else{
            System.Console.WriteLine("Element present in the list");
        }
        }
    }
}