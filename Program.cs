using System;

namespace Linear
{
  class Program 
  {
    static void Main()
    {
      ArrayList arr = new ArrayList();
            
      arr.Add(1);
      arr.Add(2);
      arr.Add(3);
      arr.Add(4);
      arr.Add(5);
      arr.Add(3);
      arr.Add(4);
      arr.Add(5);
      arr.Add(3);
      arr.Add(4);
      arr.Add(5);
      
      arr.DisplayArray();
      
      Console.WriteLine(arr.Contains(5));
      Console.WriteLine(arr.Contains(42));
      
      Console.WriteLine(arr.Remove(5));
      arr.DisplayArray();     
      
      Console.WriteLine();
      
      arr.Insert(2, 42);
      arr.DisplayArray();
        
      Console.WriteLine();
      
      arr.Clear();
      arr.DisplayArray();
    }
  }  
}

