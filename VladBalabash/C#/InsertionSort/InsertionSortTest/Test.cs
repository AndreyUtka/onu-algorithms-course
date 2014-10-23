using System;
using System.Linq;
using InsertionSort1;
using NUnit.Framework;

namespace InsertionSortTest
{
	[TestFixture]
	//[TestClasse]
	public class Test
	{
		int [] GetNotSortedArray
		{
			get{
				var random = new Random ();
				return Enumerable.Range (1, 10).OrderBy (r => random.Next ()).ToArray ();
			}
		}

		[Test]
		public void InsertionSort_Sort_ByAscending()
		{
			var notSortedArray = GetNotSortedArray;

			var sortedArray = GetNotSortedArray.OrderBy (x => x);

			var result = FirstType.insertionSort (notSortedArray);

			Assert.AreEqual (sortedArray, result);
		}
		[Test]
		public void InsertionSort_by_OperatorByAscending()
		{
			var notSortedArray = GetNotSortedArray;

			var sortedArray = GetNotSortedArray.OrderBy (x => x);

			var result = FirstType.insertionSortOperator (notSortedArray, false);
			Assert.AreEqual (sortedArray, result);
		}
		[Test]
		public void InsertionSort_by_OperatorByDescending()
		{
			var notSortedArray = GetNotSortedArray;

			var sortedArray = GetNotSortedArray.OrderByDescending (x => x);

			var result = FirstType.insertionSortOperator (notSortedArray, true);
			Assert.AreEqual (sortedArray, result);
		}

		[Test]
		public void InsertionSort_by_OperatorByDelegate()
		{
			var notSortedArray = GetNotSortedArray;

			var sortedArray = GetNotSortedArray.OrderByDescending (x => x);

			var result = FirstType.sort_delegate(notSortedArray, (x,z)=>x<z);
			Assert.AreEqual (sortedArray, result);
		}

		[Test]
		public void InsertionSort_by_OperatorByDelegate2()
		{
			var notSortedArray = GetNotSortedArray;

			var sortedArray = GetNotSortedArray.OrderBy(x => x);

			var result = FirstType.sort_delegate(notSortedArray, (x,z)=>x>z);
			Assert.AreEqual (sortedArray, result);
		}
	}
}

