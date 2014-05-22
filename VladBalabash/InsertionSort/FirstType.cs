using System;

namespace InsertionSort1
{
	public class FirstType
	{
		public static int [] insertionSort (int[] arr)
		{

			for (int i = 1; i < arr.Length; i++) {
				int currElem = arr [i];
				int prevKey = i - 1;
				while (prevKey >= 0&&arr[prevKey] > currElem) {
					arr [prevKey + 1] = arr [prevKey];
					prevKey--;
				}
				arr [prevKey + 1] = currElem;
			}
			return arr;
		}

		public static int [] sort_delegate(int [] myArray,Func<int,int,bool> check){
			for (int i=1; i<myArray.Length; i++) {
				int currentElement = myArray [i];
				int key = i - 1;
				while (key>=0&&check(myArray[key],currentElement)) {
					myArray [key+1] = myArray [key];
					key--;
				}
				myArray [key + 1] = currentElement;
			}
			return myArray;
		}

		public static int [] insertionSortOperator (int[] arr,bool flag)
		{

			for (int i = 1; i < arr.Length; i++) {
				int currElem = arr [i];
				int prevKey = i - 1;
				while (prevKey >= 0&&(flag?arr[prevKey] < currElem:arr[prevKey] > currElem)) {
					arr [prevKey + 1] = arr [prevKey];
					prevKey--;
				}
				arr [prevKey + 1] = currElem;
			}
			return arr;
		}

	}
}

