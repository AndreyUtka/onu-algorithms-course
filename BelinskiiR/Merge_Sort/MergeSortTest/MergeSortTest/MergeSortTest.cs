using System;
using System.Linq;
using MergeSort;
using NUnit.Framework;


namespace MergeSortTest
{
    [TestFixture]
    public class MergeSortTest
    {
        private int[] GetNotSortedArray
        {
            get
            {
                var random = new Random();
                return Enumerable.Range(1, 10).OrderBy(r => random.Next()).ToArray();
            }
        }

        [Test]
        public void mergeSortBase_notSortedArray_SortedArrayByAscending()
        {

            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);

            var resultArray = Merge_Sort.sort(notSortedArray);

            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }
    }
}
