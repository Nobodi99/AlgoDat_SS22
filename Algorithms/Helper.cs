using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Helper
    {
        public static void PrintArray(int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                Console.Write($"{input[i]} ");
            }
            Console.WriteLine(input[^1]);
        }
    }
}
