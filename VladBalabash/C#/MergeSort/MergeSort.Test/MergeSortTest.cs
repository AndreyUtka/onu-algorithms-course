using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace MergeSort.Test
{
    [TestFixture]
    class MergeSortTest
    {
        IEnumerable<int> GetNotSortedArray
        {
            get
            {
                var random = new Random();
                return Enumerable.Range(1, 5).OrderBy(r => random.Next()).ToArray();
            }
        }

        [Test]
        public void MergeSort_Test()
        {
            var notSortedArray = GetNotSortedArray;

            var sortArray = GetNotSortedArray.OrderBy(x => x);

            var result = MergeSortClass<int>.Sort(notSortedArray.ToList());

            Assert.AreEqual(sortArray,result);
        }

       
    }
}
