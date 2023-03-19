using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Stacks
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



        public bool oprationHandeling(string str)
        {


            var stack = new Stack<char>();
            //bool validstack = false;
            foreach (var item in str)
            {

                if (IsLeftBraket(item))
                    stack.Push(item);



                if (IsRightBraket(item))

                {
                    if (stack.Count == 0) return false;

                    var top = stack.Pop();
                    if (Bracketmatch(top, item)) return false;
                }
            }

            return stack.Count == 0;
        }

        private bool IsLeftBraket(char brk)
        {
            return brk == '(' || brk == '{' || brk == '[' || brk == '<';
        }
        private bool IsRightBraket(char brk)
        {
            return brk == ')' || brk == '}' || brk == ']' || brk == '>';
        }
        private bool Bracketmatch(char left, char right)
        {
            return
              right == ')' && left != '(' ||
               right == '}' && left != '{' ||
                right == ']' && left != '[' ||
                right == '>' && left != '<'
                ;
        }
    }
}
