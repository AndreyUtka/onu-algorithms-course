
using System.Linq;

namespace MergeSort
{
    public static class Merge_Sort
    {
        public static int[] sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(sort(massive.Take(mid_point).ToArray()), sort(massive.Skip(mid_point).ToArray()));
        }
        public static int[] merge(int[] mas1, int[] mas2)
        {
            int a = 0, b = 0;
            int[] result = new int[mas1.Length + mas2.Length];
            for (int i = 0; i < mas1.Length + mas2.Length; i++)
            {
                if (b < mas2.Length && a < mas1.Length)
                    if (mas1[a] > mas2[b] && b < mas2.Length)
                        result[i] = mas2[b++];
                    else
                        result[i] = mas1[a++];
                else
                    if (b < mas2.Length)
                        result[i] = mas2[b++];
                    else
                        result[i] = mas1[a++];
            }
            return result;
        }
    }
}

