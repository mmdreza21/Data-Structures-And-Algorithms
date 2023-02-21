namespace DataStructures
{
    public class LinkedList
    {

        private class Node
        {
            private int mmd;

            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value, Node next)
            {
                Value = value;
                this.Next = next;
            }

        }
        private Node first;
        private Node last;

        public void AddFirst(int num)
        {
            
            var node = new Node(num, first);
            node.mmd = 2;
                System.Console.WriteLine(mmd);
            first = node;
            if (last == null)
                last = node;
            
        }

        public void AddLast(int num)
        {
            var node = new Node(num, null);
            last.Next = node;
            last = node;
        }

    }
}
