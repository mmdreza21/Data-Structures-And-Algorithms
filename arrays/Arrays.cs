using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Arrays<T>
    {

        private T[] _items;
        private int count = 0;

        public Arrays(int lenght)
        {
            this._items = new T[lenght];
        }
        public void Print()
        {
            Logger<T>.LogAnArray(this._items, this.count);

        }

        public void Insert(T number)
        {
            if (_items.Length == count)
            {
                T[] newItems = new T[count * 2];

                for (int i = 0; i < _items.Length; i++)
                    newItems[i] = _items[i];

                _items = newItems;
            }

            this._items[count++] = number;
        }


        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("you gave the remove method a out of range number dud!..");

            for (int i = index; i < count; i++)
                this._items[i] = this._items[i + 1];

            this.count--;
        }

        public T[] Get_items()
        {
            return _items;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)

                //if <T> where T : class
                //if (_items[i]== item)

                // a simple scenario
                //if (EqualityComparer<T>.Default.Equals(_items[i], item))
                if (Equals(_items[i], item))
                    return i;

            return -1;
        }

        // we can use this on the instants of this class...
        public T this[int index]
        {
            get { return _items[index]; }
            private set { this._items[index] = value; }

        }

    }
}
