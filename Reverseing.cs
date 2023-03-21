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
    }
}
