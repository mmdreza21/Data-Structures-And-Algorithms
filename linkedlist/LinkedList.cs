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

        public void AddFirst(int num)
        {


            var node = new Node(num, First);
            if (IsEmpty())
                Last = node;

            First = node;

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

            var secund = this.First.Next;
            this.First.Next = null;
            this.First = secund;

        }


        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("the list is still empty! ");
            Node current = First;
            if (First == Last)
            {
                First = Last = null;
             return;
            }
            var privius = GetPrevious(this.Last);
            privius.Next = null;
            this. Last=privius;
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


        private bool IsEmpty()
        {
            return First == null;
        }



    }
}
