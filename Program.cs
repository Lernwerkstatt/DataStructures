using System;

namespace Linear
{
    class ArrayList
    {
        private int[] arr;
        public int Count { get; set; }
        
        public ArrayList()
        {
            this.arr = new int[4];
        }
        
        public void Add(int number)
        {
            if (Count == arr.Length)
            {
            int[] newArr = new int[arr.Length * 2];
            Array.Copy(this.arr, newArr, Count);
            this.arr = newArr;
            }
            this.arr[Count++] = number;
        }
        
        public int this[int index]
        {
            get
            {
            return this.arr[index];
            }
        }
    } 

    class Task
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
            
            for (int i = 0; i < arr.Count; i++)
            {
            Console.WriteLine(arr[i]);
            }
        }
        
    }
}


