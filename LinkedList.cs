using System;

namespace DataStructures
{
    public class LinkedList
    {

        private class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }
            public Node() { }
            public Node(int value, Node next)
            {
                Value = value;
                this.Next = next;
            }

        }
        private Node First;
        private Node Last;
        public int Size { get; private set; }

        public void AddFirst(int num)
        {


            var node = new Node(num, First);
            if (IsEmpty())
                Last = node;

            First = node;
            Size++;

        }

        public void AddLast(int num)
        {
            var node = new Node(num, null);
            if (IsEmpty())
            {
                Last = First = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
            Size++;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            Node current = First;
            while (current != null)
            {
                if (current.Value == item) return index;
                current = current.Next;
                index++;
            }
            return -1;

        }
        public bool Contains(int item)
        {
            return this.IndexOf(item) >= 0;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("the list is still empty! ");

            if (First == Last)
                Last = First = null;
            else
            {
                var secund = this.First.Next;
                this.First.Next = null;
                this.First = secund;
            }
            Size--;

        }


        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("the list is still empty! ");
            Node current = First;

            if (First == Last)
                First = Last = null;
            else
            {
                var privius = GetPrevious(this.Last);
                privius.Next = null;
                this.Last = privius;
            }
            Size--;
        }

        private Node GetPrevious(Node node)
        {
            Node current = First;
            while (current != null)
            {
                if (current.Next == node) return current;

                current = current.Next;
            }
            return null;
        }




        public int[] ConvertToArr()
        {
            var arr = new int[Size];
            Node current = First;
            int i = 0;
            while (current != null)
            {
                arr[i++] = current.Value;
                current = current.Next;
            }
            return arr;
        }


        public void Reverce()
        {
            if (IsEmpty())
                throw new InvalidOperationException("the list is still empty! ");
            //  [10 -> 20 -> 30 ]
            //   p      c     n
            var previouse = First;
            var current = First.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previouse;
                previouse = current;
                current = next;
            }

            Last = First;
            Last.Next = null;
            First = previouse;

            //
            //var a = First;
            //Node current = Last;

            //if (a != Last)
            //{
            //    while (current != a)
            //    {
            //        var previouse = GetPrevious(current);
            //        current.Next = previouse;
            //        current = previouse;
            //    }
            //}

            //First.Next = null;
            //First = Last;
            //Last = a;
        }

        public int GetKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new InvalidOperationException("the list is still empty! ");

            if (k <= 0)
                throw new InvalidOperationException("k can not be less than or equal to zero! ");


            //if (k > Size)
            //    throw new InvalidOperationException("k can not be grater than size of linkedList to zero! ");


            Node first = First;
            Node second = First;

            for (int i = 0; i < k - 1; i++)
            {

                second = second.Next;
                if (second == null)
                {
                    throw new InvalidOperationException("k can not be grater than size of linkedList to zero! ");
                }
            }
            while (second != Last)
            {
                first = first.Next;
                second = second.Next;
            }
            return first.Value;


        }


        public void printMiddle()
        {
            Node a = First;
            Node b = First;
            if (a == null)
            {
                throw new InvalidOperationException("k can not be grater than size of linkedList to zero! ");
            }

            while (b != Last && b.Next != Last)
            { 
                a = a.Next;
                b = b.Next.Next;
            }
                //Console.WriteLine(b.Value);
            
                if(b==Last)
                Console.WriteLine(a.Value);
                else
                Console.WriteLine(a.Value + b.Value);

        }


            public bool hasLoop()
        {
            Node a = First;
            Node b = First;
            while (b == null || b==a)
            {
                if (b == null)
                    return false;

                a = a.Next;
                b = b.Next.Next;
            }
                if (a == b)
                    return true;
                else 
                    return false;


        }


        private bool IsEmpty()
        {
            return First == null;
        }



    }
}
