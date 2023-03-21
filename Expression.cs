using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class Expression
    {

        private readonly List<char> leftlBrkList = new List<char>() { '(', '{', '[', '<' };
        private readonly List<char> righttlBrkList = new List<char>() { ')', '}', ']', '>' };

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

            return leftlBrkList.Contains(brk);
        }
        private bool IsRightBraket(char brk)
        {
            return righttlBrkList.Contains(brk);
            //return brk == || brk ==  || brk ==  || brk == ;
        }
        private bool Bracketmatch(char left, char right)
        {
            return leftlBrkList.IndexOf(left) == righttlBrkList.IndexOf(right);
        }
    }
}
