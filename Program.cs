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
            list.AddFirst(6);
            list.AddFirst(5);
            list.AddFirst(4);
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            list.AddFirst(7);
            list.AddLast(8);


            list.RemoveFirst();
            list.RemoveLast();
            list.Reverce();

            Console.WriteLine(list.Size);

            foreach (var item in list.ConvertToArr()) { Console.WriteLine(item); }


        }
    }
}
