// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class calculator
{
  
    public int Add (int A , int B)
    {
        return A + B;
    }
    
     public int Sub (int A , int B)
    {
        return A - B;
    }
}

class program
{
    public static void Main(string[] args)
    {
    
      calculator cl = new  calculator();
      Console.WriteLine ("calC start");
      
      Console.WriteLine ("Enter two Number : ");
      Console.Write("Number 1: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      
       Console.Write("Number 2: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      
      
      
      
      
    }
}
