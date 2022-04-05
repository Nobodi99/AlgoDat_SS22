using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HeapSort
    {
        /// <summary>
        /// Sort a given array by using the HeapSort algorithm
        /// </summary>
        /// <param name="input"></param>
        public void Sort(int[] input)
        {
            // Convert the input array to a heap
            BuildMaxHeap(input);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Switch A[i] with A[1]
                (input[i], input[0]) = (input[0], input[i]);

                // Build the max heap
                MaxHeapify(input, 0, i);
            }
        }

        /// <summary>
        /// Converts a given array into a heap
        /// </summary>
        /// <param name="array">The array that needs to be converted.</param>
        private void BuildMaxHeap(int[] array)
        {
            // Call MaxHeapify() for all non-leaf elements of the array/heap
            for (var i = array.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(array, i, array.Length);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">The array that needs to be sorted.</param>
        /// <param name="index">The root element of the heap.</param>
        /// <param name="heapSize">The size of the heap after the root.</param>
        private void MaxHeapify(int[] array, int index, int heapSize)
        {
            // Get the left and right indices
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest = index;

            // Check left for largest element
            if (left < heapSize && array[left] > array[largest])
            {
                largest = left;
            }

            // Check right for largest element
            if (right < heapSize && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != index)
            {
                // Swap the values at index and largest positions
                (array[index], array[largest]) = (array[largest], array[index]);

                // Recursively keep building the heap
                MaxHeapify(array, largest, heapSize);
            }
        }
    }
}
