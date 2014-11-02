using System;
using System.Collections.Generic;

namespace MergeSort
{
    public class MergeSortClass<T> where T : struct
    {
        public static List<T> Sort(List<T> input)
        {
            var left = new List<T>();
            var right = new List<T>();

            if (input.Count <= 1)
                return input;

            var midpoint = input.Count / 2;
            for (var i = 0; i < midpoint; i++)
                left.Add(input[i]);
            for (var i = midpoint; i < input.Count; i++)
                right.Add(input[i]);

            left = Sort(left); //Recursion! :o
            right = Sort(right);
            var result = Merge(left, right);

            return result;
        }

        private static List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (Convert.ToInt64(left[0]) < Convert.ToInt64(right[0]))
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }
    }
}
