using System;

namespace InsertionSort1
{
	public class SeconType
	{
		static int [] insertionSort (int[] arr,bool flag)
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

