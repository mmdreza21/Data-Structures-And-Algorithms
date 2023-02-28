using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var list = new LinkedList();

            list.AddFirst(8);
            list.AddFirst(7);
            list.AddFirst(6);
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            //list.AddFirst(7);
            //list.AddLast(8);
            //list.AddLast(2);
            //list.AddLast(1);


            //list.RemoveFirst();
            //list.RemoveLast();
            //list.Reverce();
            //list.GetKthFromTheEnd(2);
              Console.WriteLine(list.printMiddle());

            //Console.WriteLine(list.GetKthFromTheEnd(100));



        }
    }
}
