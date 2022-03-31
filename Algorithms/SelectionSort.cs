using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            // Traverse the array position by position
            // The idea is to set every position to the lowest element we can find to the right of it
            for (int i = 0; i < array.Length; i++)
            {
                // Pointer to the position of the lowest element
                var min = i;

                // Traverse through all elements to the right of our current position
                for (int j = i; j < array.Length; j++)
                {
                    // When we find an element that is smaller then our current smallest pointer
                    // then we set our pointer to the newest found element
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                // After we found the smallest element in our remaining sequence we will switch it
                // with the element on the current position
                (array[i], array[min]) = (array[min], array[i]);
            }

            return array;
        }

        /*  Example:
         *
         *  Array: [ 40, 15, 31, 8, 26, 22 ]
         *
         *  ">" points to the current position
         *  "<" points to the switched element
         *
         *  >40 15 31 8   26 22
         *   8  15 31 40< 26 22
         *   8 >15 31 40  26 22
         * ...
         */
    }
}
