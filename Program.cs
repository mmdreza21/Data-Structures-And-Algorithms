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

ArrayQueue q = new ArrayQueue(4);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);

            q.Dequeue();
            q.Dequeue();


            q.Enqueue(33);
            q.Enqueue(44);

            q.Dequeue();
            q.Dequeue();
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.IsEmpty());
            Console.WriteLine(q.IsFull());

            q.Log();

        }

         
    }
}
