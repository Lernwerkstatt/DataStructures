using System;

namespace Linear
{
    public class ArrayList<T>
    {
        private T[] arrayList;
        public int Count { get; set; }
        public ArrayList()
        {
            this.arrayList = new T[4];
        }
        public void Insert(int index, T value)
        {
            T[] newArr = new T[Count];
            Array.Copy(this.arrayList, newArr, index);
            newArr[index] = value;
            Array.Copy(this.arrayList, index + 1, newArr, index + 1, Count - index - 1);
            this.arrayList = newArr;
            
        }
        public void Clear()
        {
            Count = 0;
        }
        public int Remove(T data)
        {
            int result = -1;

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (data.Equals(this.arrayList[i]))
                {
                    T[] newArr = new T[arrayList.Length - 1];

                    Array.Copy(this.arrayList, newArr, i);
                    Array.Copy(this.arrayList, i + 1, newArr, i, newArr.Length - i);
                    this.arrayList = newArr;
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
            
            foreach (T item in this.arrayList)
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
            if (Count == arrayList.Length)
            {
                T[] newArr = new T[arrayList.Length * 2];
                Array.Copy(this.arrayList, newArr, Count);
                this.arrayList = newArr;
            }
            this.arrayList[Count++] = data;
        }
        
        public T this[int index]
        {
            get
            {
                return this.arrayList[index];
            }
        }
        public void DisplayArray()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(this.arrayList[i] + " ");
            }
            Console.WriteLine();
        }
    } 
}
