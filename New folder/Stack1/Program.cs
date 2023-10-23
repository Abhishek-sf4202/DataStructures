using System;
namespace Program{
    class Program{
        static int size= 100;
        static int count = -1;
        static int[] array = new int[size];
        public static void Main(string[] args)
        {
            bool check = true;
            do
            {
               System.Console.WriteLine("Enter 1 to push");
            System.Console.WriteLine("Enter 2 to Pop");
            System.Console.WriteLine("Enter 3 to peak");
            System.Console.WriteLine("Enter 4 to Exit");
            System.Console.WriteLine();
            int value = int.Parse(Console.ReadLine());
            switch(value)
            {
                case 1:{
                    Push();
                    break;
                }
                case 2:{
                    Pop();
                    break;
                }
                case 3:{
                     peak();
                    break;
                }
                case 4:{
                    System.Console.WriteLine("BYE");
                    check = false;
                    break;
                }
                default:{
                    System.Console.WriteLine("Enter Correct Number 1/2/3");
                    break;
                }
            }  
            } while (check);
           
        }
        public static void Push()
        {
            if(count == size)
            {
                System.Console.WriteLine("OverFlow");
            }
            else{
                count+=1;
                System.Console.WriteLine("Enter a Number to Insert");
                array[count] = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Element added to stack");
            }
        }
        public static void Pop()
        {
            if(count == -1)
            {
                System.Console.WriteLine("UnderFLow");
            }
            else{
               count = count-1;
               System.Console.WriteLine("Element removed");
            }
        }
        public static void peak()
        {
             if(count == -1)
            {
                System.Console.WriteLine("UnderFLow");
            }
            else{
                System.Console.WriteLine("Peak element"+array[count]);
            }
        }
    }
}