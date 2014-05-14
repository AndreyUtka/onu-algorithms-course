using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit.Framework;

namespace SortTest
{
    [TestFixture]
    class SortTest
    {
        private int[] GetNotSortArray
        {
            get
            {
                var random = new Random();
                return Enumerable.Range(1, 10).OrderBy(r => random.Next()).ToArray();
            }
        }

        [Test]
        public void sortTest()
        {
            var NotSortArrey = GetNotSortArray;
            var massive = NotSortArrey.OrderBy(x => x);
            //var sort = new ClassLibrary1.InsertionSort();
            //var result = sort.ArraySort(massiveSort);
            var result = InsertionSort.ArraySort(NotSortArrey);
            Assert.AreEqual(massive, result);
        }

        [Test]
        public void SortTestTrenary()
        {
            var NotSortArrey = GetNotSortArray;
            var massive = NotSortArrey.OrderBy(x => x);
            var result = InsertionSort.ArraySort(NotSortArrey, false);
            Assert.AreEqual(massive, result);
        }
        [Test]
        public void SortTestTrenary_ByDescending()
        {
            var NotSortArrey = GetNotSortArray;
            var massive = NotSortArrey.OrderByDescending(x => x);
            var result = InsertionSort.ArraySort(NotSortArrey, true);
            Assert.AreEqual(massive, result);
        }

        [Test]
        public void SortTestTrenary_Delegate()
        {
            var NotSortArrey = GetNotSortArray;
            var massive = NotSortArrey.OrderBy(x => x);
            var result = InsertionSort.ArraySortDelegate(NotSortArrey, (x, y) => x > y);
            Assert.AreEqual(massive, result);
        }
        [Test]
        public void SortTestTrenary_Delegate_ByDescending()
        {
            var NotSortArrey = GetNotSortArray;
            var massive = NotSortArrey.OrderByDescending(x => x);
            var result = InsertionSort.ArraySortDelegate(NotSortArrey, (x, y) => x < y);
            Assert.AreEqual(massive, result);
        }


    }
}
