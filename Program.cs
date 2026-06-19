using System;

namespace DataStructures
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int[] arr = { 100, 2, 3, 4, 5, 6, 7, 8, 9 };

            var ex = new HSExercises();


            Console.WriteLine(ex.TwoSum(arr, 9)[0] + " " + ex.TwoSum(arr, 9)[1]);

        }


    }
}
