using System;

using System.Linq;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArrays = Console.ReadLine()
                .Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArrays = Console.ReadLine()
                .Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int length = Math.Min(firstArrays.Length, secondArrays.Length);
            int counter = 0;
            for (int index = 0; index < length; index++)
            {
                if (firstArrays[index] == secondArrays[index])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            Array.Reverse(firstArrays);
            Array.Reverse(secondArrays);
            int reversecounter = 0;

            for (int i = length; i > 0; i--)
            {
                reversecounter++;
                if (true)
                {

                }
            }

        }
    }
}
