using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleSort
    {
        public int[] Sort(int[] input)
        {
            // Traverse through each position of the array
            for (int i = 0; i < input.Length; i++)
            {
                // Starting from the end of the array move the smallest element to the front
                for (int j = input.Length - 1; j > i; j--)
                {
                    // Move tghe smaller element to the left
                    if (input[j] < input[j - 1])
                    {
                        // Switch 2 elements
                        (input[j], input[j - 1]) = (input[j - 1], input[j]);
                    }
                }
            }

            // Return the sorted array
            return input;
        }
    }
}
