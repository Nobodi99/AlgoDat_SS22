using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinSearch
    {
        public int? BinSearchRecursive(int[] input, int left, int right, int goal)
        {
            if (left > right)
            {
                return null;
            }

            var mid = (int)Math.Floor((double)(left + right) / 2);

            if (mid == goal)
            {
                return mid;
            }

            if (mid < goal)
            {
                return BinSearchRecursive(input, left, mid, goal);
            }

            return BinSearchRecursive(input, mid + 1, right, goal);
        }

        public int? BinSearchIterative(int[] input, int left, int right, int goal)
        {
            while (true)
            {
                if (left > right)
                {
                    return null;
                }

                var mid = (int)Math.Floor((double)(left + right) / 2);

                if (mid == goal)
                {
                    return mid;
                }

                if (mid < goal)
                {
                    right = mid;
                    continue;
                }

                left = mid + 1;
            }
        }
    }
}
