using System;

namespace InsertionSort1
{
	public class DelegateType
	{
		public static void Main (string[] args)
		{
			int [] myArray=new int[10];
			sort_delegate (myArray, (x,y) => x < y);
		}
		static int [] sort_delegate(int [] myArray,Func<int,int,bool> check){
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



	}
}

