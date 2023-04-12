using System;

namespace DataStructures
{
    public class ArrayQueue
    {
        int[] Items;
        private int size = 0;
        int F = 0;
        int R = 0;

        public int Count { get; set; }

        public ArrayQueue(int length)
        {
            this.size = length;
            Items = new int[length];
        }



        public void Log()
        {
            Logger<int>.LogAnArray(Items, Count);
        }





        public void Enqueue(int item)
        {
            if (IsFull())
                throw new IndexOutOfRangeException("the Queue is Full bro...!");

            this.Items[R] = item;
            R = (R + 1) % size;
            Count++;

        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("the Queue is already empry bro...!");

            var item = Items[F];
            Items[F] = 0;
            F = (F + 1) % size;
            Count--;

            return item;

        }


        public bool IsEmpty()
        {
            return Count ==0;
        }

        public bool IsFull()
        {
            return Count == size;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("the Queue is already empry bro...!");
            return Items[F];
        }




    }
}
