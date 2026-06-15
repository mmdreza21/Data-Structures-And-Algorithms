using System;

namespace DataStructures
{
    internal class Tree
    {
        private Node root;
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;
            public Node(int value)
            {
                this.value = value;
            }
        }
        public Tree() { }

        public void Insert(int value) => root = Insert(value, root);
        private Node Insert(int value, Node node)
        {
            if (node == null)
                return new Node(value);
            if (value < node.value) node.leftChild = Insert(value, node.leftChild);
            else node.rightChild = Insert(value, node.rightChild);

            return node;
        }

        public bool Find(int value)
        {
            Node current = root;
            while (current != null)
            {
                if (current.value == value) return true;
                if (current.value > value) current = current.leftChild;
                else current = current.rightChild;
            }
            return false;
        }

        public bool Contain(int value) => Contain(value, root);
        private bool Contain(int value, Node node)
        {
            if (node == null) return false;
            if (node.value == value) return true;
            return Contain(value, node.leftChild) || Contain(value, node.rightChild);
        }


        public void TravercePreOrder() => TravercePreOrder(root);
        private void TravercePreOrder(Node node)
        {
            if (node == null) return;
            int d = node.value;
            Console.WriteLine(node.value);
            TravercePreOrder(node.leftChild);
            TravercePreOrder(node.rightChild);
        }

        public void TraverceInOrder() => TraverceInOrder(root);
        private void TraverceInOrder(Node node)
        {
            if (node == null) return;
            int d = node.value;
            TraverceInOrder(node.leftChild);
            Console.WriteLine(node.value);
            TraverceInOrder(node.rightChild);
        }

        public void TravercePostOrder() => TravercePostOrder(root);
        private void TravercePostOrder(Node node)
        {
            if (node == null) return;
            int d = node.value;
            TravercePostOrder(node.leftChild);
            TravercePostOrder(node.rightChild);
            Console.WriteLine(node.value);
        }

        public int Height() => Height(root);
        private int Height(Node node)
        {
            if (node == null) return 0;
            if (IsLeaf(node)) return -1;

            return Math.Max(Height(node.leftChild), Height(node.rightChild)) + 1;
        }

        public int Min() => Min(root);
        private int Min(Node node)
        {
            if (node == null) return int.MaxValue;

            int minLeft = Min(node.leftChild);
            int minRight = Min(node.rightChild);

            return Math.Min(Math.Min(minLeft, minRight), node.value);
        }

        public int CountLeaf() => CountLeaf(root);
        private int CountLeaf(Node node)
        {
            if (node == null) return 0;

            return CountLeaf(node.leftChild) + CountLeaf(node.rightChild) + 1;
        }





        private bool IsLeaf(Node node) => node.leftChild == null && node.rightChild == null;
    }
}
