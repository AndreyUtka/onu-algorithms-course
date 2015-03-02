using System;
using System.Linq;
using Algorithms.Sorting;
using NUnit.Framework;

namespace Algorithms.SortingTest
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
            var resultArray = InsertionSort.InsertionSortBase(notSortedArray);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }

        [Test]
        public void InsertionSortWithTernaryOperator_NotSortedArray_SortedArrayByAscending()
        {
            //Arrange 
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);
            //Act
            var resultArray = InsertionSort.InsertionSortWithTernaryOperator(notSortedArray, false);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }
        [Test]
        public void InsertionSortWithTernaryOperator_NotSortedArray_SortedArrayByDescending()
        {
            //Arrange 
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderByDescending(x => x);
            //Act
            var resultArray = InsertionSort.InsertionSortWithTernaryOperator(notSortedArray, true);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }
        [Test]
        public void InsertionSortWithDelegate_NotSortedArray_SortedArrayByAscending()
        {
            //Arrange 
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderBy(x => x);
            //Act
            var resultArray = InsertionSort.InsertionSortWithDelegate(notSortedArray, (x,y) => x > y);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }
        [Test]
        public void InsertionSortWithDelegate_NotSortedArray_SortedArrayByDescending()
        {
            //Arrange 
            var notSortedArray = GetNotSortedArray;
            var sortedArrayByAscending = notSortedArray.OrderByDescending(x => x);
            //Act
            var resultArray = InsertionSort.InsertionSortWithDelegate(notSortedArray, (x, y) => x < y);
            //Assert
            Assert.AreEqual(resultArray, sortedArrayByAscending);
        }
    }
}