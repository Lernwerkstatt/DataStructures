using System;

namespace Linear
{
    class ArrayList
    {
        private int[] arr;
        public int Count { get; set; }
        public int test;

        public ArrayList()
        {
            this.arr = new int[4];
        }

        public void Clear()
        {

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
                    Array.Copy(this.arr, i + 1, newArr, i, newArr.Length - i);
                    this.arr = newArr;

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
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.Contains(5));
            Console.WriteLine(arr.Contains(42));

            Console.WriteLine(arr.Remove(5));
            //Console.WriteLine(arr.Remove(42));

            for (int i = 0; i < arr.Count - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

