using System;
using System.Linq;
using System.Collections.Generic;



namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Reverse(arr);
            Console.WriteLine(arr[0]);
        }
    }
}
