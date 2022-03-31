namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                // Save current element in a variable
                var key = array[j];

                // Set starting index to the element left of the current element
                var i = j - 1;

                // Traverse the array to the left until we reach the end
                // or we detect an element that is smaller then our key element
                // To sort the array in descending order we just need to change the condition of
                // "array[i] < key" to "array[i] > key"
                while (i >= 0 && array[i] < key)
                {
                    // Set the element to the right of our current index to the element at the index
                    // During this we "remove" the key from the array and temporarily have duplicate elements
                    array[i + 1] = array[i];
                    i -= 1;
                }

                // When the index i points at a smaller element then the key element or we reached the front of the array
                // then we set the next/first element to our key element.
                array[i + 1] = key;
            }

            return array;
        }

        /*  Example:
         *
         *  Array [ 31, 41, 59, 26, 41, 58 ]
         *
         *  ">" will point to the key element
         *  "<" points to the moved element
         *
         *  31 >41  59  26  41  58
         *  31  41 >59  26  41  58
         *  31  41  59 >26  41  58
         *  26< 31  41  59 >41  58
         *  26  31  41  41< 59 >58
         *  26  31  41  41  58< 59  <- Completely sorted
         */
    }
}