using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Reverseing
    {
        public void reverseStr(string str)
        {
            var stack = new Stack<char>();
            if (str == null || str == "")
                throw new ArgumentNullException("nooo dont gime emptistr or null...");

            foreach (var item in str)
                stack.Push(item);

            while (stack.Count > 0)
                Console.Write(stack.Pop());
            Console.WriteLine();
        }

        public void reverseQueue(Queue<int> queue)
        {
            var stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());

            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }


    }
}
