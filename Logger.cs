using System;

namespace DataStructures
{
    public class Logger<T>
    {

        public static void LogAnArray(T[] arr, int count)
        {
            Console.Write("[");
            for (int i = 0; i < count; i++)

            {
                Console.Write(arr[i]);
                if (i != count - 1)
                    Console.Write(",");
            }
            Console.WriteLine("]");
        }



    }
}
