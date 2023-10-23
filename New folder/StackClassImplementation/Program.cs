using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Stack;
class Program{
    static Stack<int> numbers = new Stack<int>();
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
                     Peak();
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
    public static void Push(){
        System.Console.WriteLine("Enter element to push");
        int number = int.Parse(Console.ReadLine());
        numbers.Push(number);
        System.Console.WriteLine("Number pushed");
    }
     public static void Pop(){
        if(numbers.Count == 0)
        {
            System.Console.WriteLine("No element present in the list");
        }
        else{
            System.Console.WriteLine($"Element Poped {numbers.Pop()}");
        }
    }
     public static void Peak(){
         if(numbers.Count == 0)
        {
            System.Console.WriteLine("No element present in the list");
        }
        else{
             System.Console.WriteLine($"Peak Element{numbers.Peek()}");
        }
       
    }
}