using System;

namespace Linear
{
    public class ArrayList<T>
    {
        private T[] array;
        public int Count { get; set; }
        public ArrayList()
        {
            this.array = new T[4];
        }
        public void Insert(int index, T value)
        {
            T[] newArr = new T[Count];
            Array.Copy(this.array, newArr, index);
            newArr[index] = value;
            Array.Copy(this.array, index + 1, newArr, index + 1, Count - index - 1);
            this.array = newArr;
            
        }
        public void Clear()
        {
            Count = 0;
        }
        public int Remove(T data)
        {
            int result = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (data.Equals(this.array[i]))
                {
                    T[] newArr = new T[array.Length - 1];

                    Array.Copy(this.array, newArr, i);
                    Array.Copy(this.array, i + 1, newArr, i, newArr.Length - i);
                    this.array = newArr;
                    Count--;
                    result = i;

                    return result;
                }
            }
            
            return result;
        }
        public bool Contains(T data)
        {
            bool result = false;
            
            foreach (T item in this.array)
            {
                if (item.Equals(data))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        
        public void Add(T data)
        {
            if (Count == array.Length)
            {
                T[] newArr = new T[array.Length * 2];
                Array.Copy(this.array, newArr, Count);
                this.array = newArr;
            }
            this.array[Count++] = data;
        }
        
        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
        }
        public void DisplayArray()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(this.array[i] + " ");
            }
            Console.WriteLine();
        }
    } 
}
