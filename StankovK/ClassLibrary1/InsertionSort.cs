using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public static class InsertionSort
    {
        
        public static int[] ArraySort(int[] mas)
        {
            int x, j;
            for (int i = 1; i < mas.Length; i++)
            {
                x = mas[i];
                for (j = i - 1; j >= 0 && mas[j] > x; j--)
                    mas[j + 1] = mas[j];

                mas[j + 1] = x;
            }
            return mas;
        }

        public static int[] ArraySort(int[] mas, bool token)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int x = mas[i];
                int j = i - 1;
                while (j >= 0 && (token ? (mas[j] < x) : (mas[j] > x)))
                {
                    mas[j + 1] = mas[j];
                    j--;
                }
                mas[j + 1] = x;
            }
            return mas;
        }
        public static int[] ArraySortDelegate(int[] mas, Func<int, int, bool> comparator )
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int x = mas[i];
                int j = i - 1;
                while (j >= 0 && comparator (mas[j],x))
                {
                    mas[j + 1] = mas[j];
                    j--;
                }
                mas[j + 1] = x;
            }
            return mas;
        }
    }
}
