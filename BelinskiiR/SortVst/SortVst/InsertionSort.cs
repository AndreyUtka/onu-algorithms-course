using System;

namespace SortVst
{
    public static class InsertionSort
    {
        public static int[] SortWithDelegate(int[] mas, Func<int, int, bool> compare)
        {

            int curEl, Key;
            for (int j = 1; j < mas.Length; j++)
            {
                curEl = mas[j];
                Key = j - 1;
                while (Key >= 0 && compare(mas[Key], curEl))
                {
                    mas[Key + 1] = mas[Key];
                    Key--;
                }
                mas[Key + 1] = curEl;
            }
            return mas;
        }
        public static int[] SortTrinar(int[] mas, bool fl)
        {

            int curEl, Key;
            for (int j = 1; j < mas.Length; j++)
            {
                curEl = mas[j];
                Key = j - 1;
                while (Key >= 0 && (fl ? mas[Key] > curEl : mas[Key] < curEl))
                {
                    mas[Key + 1] = mas[Key];
                    Key--;
                }
                mas[Key + 1] = curEl;
            }
            return mas;
        }
        public static int[] Sort(int[] mas)
        {
            int curEl, Key;
            for (int j = 1; j < mas.Length; j++)
            {
                curEl = mas[j];
                Key = j - 1;
                while (Key >= 0 && mas[Key] > curEl)
                {
                    mas[Key + 1] = mas[Key];
                    Key--;
                }
                mas[Key + 1] = curEl;
            }
            return mas;
        }
    }
}