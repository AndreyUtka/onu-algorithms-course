using System;
using System.Linq;
using NUnit.Framework;
using SortVst;

namespace Algorithms.SortVsrTest
{
    [TestFixture]
    public class InsertionSortTest
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
        public void InsertionSortBase_NotSortedArray_SortedArrayByAscending()
        {
            //Arrange
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);
            //Act
            var resultArray = InsertionSort.Sort(notSortedArray);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }

        [Test]
        public void InsertionSortWithTrinar_NotSortedArray_SortedArrayByAscending()
        {
            //Arrange
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);
            //Act
            var resultArray = InsertionSort.SortTrinar(notSortedArray, true);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }

        [Test]
        public void InsertionSortWithTrinar_NotSortedArray_SortedArrayByDecending()
        {
            //Arrange
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByDecending = notSortedArray.OrderByDescending(x => x);
            //Act
            var resultArray = InsertionSort.SortTrinar(notSortedArray, false);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByDecending);
        }

        [Test]
        public void InsertionSortWithDelegate_NotSortedArray_SortedArrayByAscending()
        {
            //Arrange
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);
            //Act
            var resultArray = InsertionSort.SortWithDelegate(notSortedArray, (x, y) => x > y);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }

        [Test]
        public void InsertionSortWithDelegate_NotSortedArray_SortedArrayByDescending()
        {
            //Arrange
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByDescending = notSortedArray.OrderByDescending(x => x);
            //Act
            var resultArray = InsertionSort.SortWithDelegate(notSortedArray, (x, y) => x < y);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByDescending);
        }
    }
}
