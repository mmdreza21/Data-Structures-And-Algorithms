using System;

namespace DataStructures
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[] arr = { 100, 2, 3, 4, 5, 6, 101, 102, 7, 8, 9 };
            int[] arr2 = { 5, 4, 3, 5, 4 };

            var ex = new HSExercises();

            Console.WriteLine(ex.SecondLargest(arr2));

        }


    }
}
