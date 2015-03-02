using System;

namespace Algorithms.Sorting
{
    public class InsertionSort
    {
        public static int[] InsertionSortBase(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var currentElement = array[i];
                var previousKey = i - 1;
                while (previousKey >= 0 && array[previousKey] > currentElement)
                {
                    array[previousKey + 1] = array[previousKey];
                    previousKey--;
                }
                array[previousKey + 1] = currentElement;
            }
            return array;
        }
        public static int[] InsertionSortWithTernaryOperator(int[] array, bool token)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var currentElement = array[i];
                var previousKey = i - 1;
                while (previousKey >= 0 && (token ? (array[previousKey] < currentElement) :
                                                    (array[previousKey] > currentElement)))
                {
                    array[previousKey + 1] = array[previousKey];
                    previousKey--;
                }
                array[previousKey + 1] = currentElement;
            }
            return array;
        }
        public static int[] InsertionSortWithDelegate(int[] array, Func<int, int, bool> comparator)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var currentElement = array[i];
                var previousKey = i - 1;
                while (previousKey >= 0 && comparator(array[previousKey], currentElement))
                {
                    array[previousKey + 1] = array[previousKey];
                    previousKey--;
                }
                array[previousKey + 1] = currentElement;
            }
            return array;
        }
    }
}