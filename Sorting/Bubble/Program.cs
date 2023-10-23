using System;
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
        for(int i=0;i<value;i++)
        {
            for(int j=i+1;j<value;j++)
            {
                if(array[i]>array[j]){
                     int temp = array[i];
                array[i] = array[j];
                array[j] = temp; 
                }
               
            }
        }
         for(int i=0;i<value;i++)
        {
            System.Console.Write($"\t {array[i]}");
        }
    }
}