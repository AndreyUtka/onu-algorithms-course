using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static List<int> Sort(List<int> input)
        {
            List<int> Result = new List<int>();
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            if (input.Count <= 1)
                return input;

            int midpoint = input.Count / 2;
            for (int i = 0; i < midpoint; i++)
                Left.Add(input[i]);
            for (int i = midpoint; i < input.Count; i++)
                Right.Add(input[i]);

            Left = Sort(Left); //Recursion! :o
            Right = Sort(Right);
            Result = Merge(Left, Right);

            return Result;
        }

        private static List<int> Merge(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();
            while (Left.Count > 0 && Right.Count > 0)
            {
                if (Left[0] < Right[0])
                {
                    Result.Add(Left[0]);
                    Left.RemoveAt(0);
                }
                else
                {
                    Result.Add(Right[0]);
                    Right.RemoveAt(0);
                }
            }

            while (Left.Count > 0)
            {
                Result.Add(Left[0]);
                Left.RemoveAt(0);
            }

            while (Right.Count > 0)
            {
                Result.Add(Right[0]);
                Right.RemoveAt(0);
            }

            return Result;
        }
    }
}
