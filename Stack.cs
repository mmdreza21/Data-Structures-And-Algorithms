using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Stack
    {

        private int[] _items = new int[10];

        //count
        public int count { get; private set; }

        //push
        public void Push(int val)
        {
            if (count == _items.Length)
                throw new StackOverflowException("stack overflow...");

            _items[count++] = val;
        }

        //pop
        public int Pop()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("the stack is allReady empty");
            var last = _items[count];
            _items[count--] = 0;
            return last;
        }
        //peek
        public int Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("the stack is allReady empty");
            return _items[count];
        }
        //isEmpty
        public bool IsEmpty()
        {
            return count == 0;
        }


        public override string ToString()
        {
            var str = "[";
            for (int i = 0; i < count; i++)
            {
                str += _items[i].ToString();

                if (i < count - 1)
                    str += " , ";
            }
            str += "]";
            return str;

        }






    }
}
