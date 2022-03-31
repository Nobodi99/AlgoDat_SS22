using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MergeSort
    {
        public int[] Sort(int[] input)
        {
            // Call the recursive Sort-method with the initial length of the array
            return Sort(input, 0, input.Length - 1);
        }

        private int[] Sort(int[] input, int left, int right)
        {
            if (left < right)
            {
                // Get the middle of the array rounded to the nearest, lowest integer
                var tmp = left + right;
                var middle = (int)Math.Floor((double)tmp / 2);

                input = Sort(input, left, middle);
                input = Sort(input, middle + 1, right);
                input = Merge(input, left, middle, right);
            }

            return input;
        }

        private int[] Merge(int[] input, int left, int middle, int right)
        {
            // Get lengths of the new array
            var lengthLeft = middle - left + 1;
            var lengthRight = right - middle;

            // Create new arrays for the split
            var leftArray = new int[lengthLeft];
            var rightArray = new int[lengthRight];

            // Copy the portions from the input array to the new splits
            Array.Copy(input, left, leftArray, 0, lengthLeft);
            Array.Copy(input, middle + 1, rightArray, 0, lengthRight);

            // Create helper indexes to traverse the arrays
            var leftIndex = 0;
            var rightIndex = 0;
            var inputIndex = left;

            // Sort and merge the arrays
            while (leftIndex != lengthLeft && rightIndex != lengthRight)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    input[inputIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    input[inputIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                inputIndex++;
            }

            // When the end of left array is reached first we fill the input array with the rest of the right array
            if (leftIndex == lengthLeft)
            {
                for (var m = rightIndex; m < lengthRight; m++)
                {
                    input[inputIndex] = rightArray[m];
                    inputIndex++;
                }

                // return the array because we are done
                return input;
            }

            // When the end of right array is reached first we fill the input array with the rest of the left array
            for (var m = leftIndex; m < lengthLeft; m++)
            {
                input[inputIndex] = leftArray[m];
                inputIndex++;
            }

            PrintArray(input);
            // Return the array after sorting
            return input;
        }

        public void PrintArray(int[] input)
        {
            foreach (var i in input)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
