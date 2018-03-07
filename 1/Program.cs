using System;
using System.Collections.Generic;
using System.Linq;


namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').ToArray();
            var secondArr = Console.ReadLine().Split(' ').ToArray();
            var caounterLength = 0;

            var leftCounter = 0;
            var rightCounter = 0;

            while (leftCounter < firstArr.Length && leftCounter < secondArr.Length)
            {

                if (firstArr[leftCounter] == secondArr[leftCounter])
                {
                    leftCounter++;

                }
                else
                {
                    break;
                }
            }
            while (rightCounter< firstArr.Length && rightCounter< secondArr.Length)
            {
                if (firstArr[firstArr.Length-1- rightCounter] == secondArr[secondArr.Length-1 - rightCounter])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }
            if (rightCounter < leftCounter)
            {
                Console.WriteLine(leftCounter);
            }
            else
            {
                Console.WriteLine(rightCounter);
            }

        }
    }
}
