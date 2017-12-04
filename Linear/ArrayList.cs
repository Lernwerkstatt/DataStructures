using System;

namespace Linear
{
    public class ArrayList
    {
        private int[] arr;
        public int Count { get; set; }
        public ArrayList()
        {
            this.arr = new int[4];
        }
        public void Insert(int index, int value)
        {
            int[] newArr = new int[arr.Length + 1];
            
            Array.Copy(this.arr, newArr, index);
            newArr[index] = value;
            Array.Copy(this.arr, index, newArr, index + 1, arr.Length - index);
            this.arr = newArr;
            Count++;
        }
        public void Clear()
        {
            this.arr = new int[4];
            Count = 0;
        }
        public int Remove(int number)
        {
            int result = -1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (number == this.arr[i])
                {
                    int[] newArr = new int[arr.Length - 1];
                    
                    Array.Copy(this.arr, newArr, i);
                    Array.Copy(this.arr, i+1, newArr, i, newArr.Length - i);
                    this.arr = newArr;
                    Count--;
                    result = i;
                    
                    return result;
                }
            }
            return result;
        }
        public bool Contains(int number)
        {
            bool result = false;
            
            foreach (int item in this.arr)
            {
                if (item == number)
                {
                    result = true;
                    break;
                }
            }
            return result;
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
        public void DisplayArray()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(this.arr[i] + " ");
            }
            Console.WriteLine();
        }
    } 
}
