using System;

namespace Generic
{
    public class ArrayList<T>
    {
        private T[] arr;
        public int Count { get; set; }
        public ArrayList()
        {
            this.arr = new T[4];
        }
        public void Insert(int index, T value)
        {
            T[] newArr = new T[Count];
            Array.Copy(this.arr, newArr, index);
            newArr[index] = value;
            Array.Copy(this.arr, index + 1, newArr, index + 1, Count - index - 1);
            this.arr = newArr;
            
        }
        public void Clear()
        {
            this.arr = new T[4];
            Count = 0;
        }
        public int Remove(T number)
        {
            int result = -1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (number.Equals(this.arr[i]))
                {
                    T[] newArr = new T[arr.Length - 1];
                    
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
        public bool Contains(T number)
        {
            bool result = false;
            
            foreach (T item in this.arr)
            {
                if (item.Equals(number))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        
        public void Add(T number)
        {
            if (Count == arr.Length)
            {
                T[] newArr = new T[arr.Length * 2];
                Array.Copy(this.arr, newArr, Count);
                this.arr = newArr;
            }
            this.arr[Count++] = number;
        }
        
        public T this[int index]
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
