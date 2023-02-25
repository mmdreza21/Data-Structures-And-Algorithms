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
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(5);
            list.AddLast(6);

            //list.RemoveFirst();
            list.RemoveLast();



            Console.WriteLine(list.IndexOf(98));
            Console.WriteLine(list.Contains(12));



        }
    }
}
