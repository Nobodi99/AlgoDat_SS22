using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QuickSort
    {
        public static int Partition(int[] array, int first, int last)
        {
            int x = array[last];
            int i = first - 1;

            for (int j = first; j <= last - 1; j++)
            {
                if (array[j] <= x)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            (array[i + 1], array[last]) = (array[last], array[i + 1]);

            return i + 1;
        }

        public static int HoarePartition(int[] array, int first, int last)
        {
            int x = array[first];
            int i = first - 1;
            int j = last + 1;
            Helper.PrintArray(array);
            while (true)
            {
                do
                {
                    j--;
                } while (array[j] > x);

                do
                {
                    i++;
                } while (array[i] < x);

                if (i < j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    Helper.PrintArray(array);
                }
                else
                {
                    Helper.PrintArray(array);
                    return j;
                }
            }
        }

        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        public static void Sort(int[] array, int first, int last)
        {
            Helper.PrintArray(array);
            if (first < last)
            {
                int index = Partition(array, first, last);

                Sort(array, first, index - 1);
                Sort(array, index + 1, last);
            }

            
        }
    }
}
