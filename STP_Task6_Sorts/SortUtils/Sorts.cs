using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortUtils
{
    public static class Sorts
    {
        public delegate int CompareDelegate<TValue>(TValue item0, TValue item1);

        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> array) where T : IComparable<T>
        {
            if (!array.Any())
            {
                return Enumerable.Empty<T>();
            }
            var pivot = array.First();
            var smaller = array.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();
            var larger = array.Skip(1).Where(item => item.CompareTo(pivot) > 0).QuickSort();

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }


        public static IEnumerable<TValue> QuickSortWithDelegate<TValue>
            (this IEnumerable<TValue> array, CompareDelegate<TValue> compareDelegate)
        {
            if (!array.Any())
            {
                return Enumerable.Empty<TValue>();
            }
            var pivot = array.First();
            var smaller = array.Skip(1).Where(item => compareDelegate(item, pivot) <= 0).QuickSortWithDelegate(compareDelegate);
            var larger = array.Skip(1).Where(item => compareDelegate(item, pivot) > 0).QuickSortWithDelegate(compareDelegate);

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }


        public static IEnumerable<TValue> BubbleSort<TValue>(this IEnumerable<TValue> item) where TValue : IComparable<TValue>
        {
            int i, j;
            TValue temp;
            var array = item.ToArray();
            for (i = array.Count() - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }


        public static IEnumerable<TValue> BubbleSortWithDelegate<TValue>(this IEnumerable<TValue> item, CompareDelegate<TValue> compareDelegate)
        {
            int i, j;
            TValue temp;
            var array = item.ToArray();
            for (i = array.Count() - 1; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    if (compareDelegate(array[j], array[j + 1]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }


        public static IEnumerable<TValue> SelectionSortWithDelegate<TValue>(this IEnumerable<TValue> item, CompareDelegate<TValue> compareDelegate)
        {
            var list = item.ToList();
            for (int i = 0; i < list.Count() - 1; ++i)
            {
                TValue minElement = list[i];
                int minLocation = i;

                for (int j = i + 1; j < list.Count(); ++j)
                {
                    if (compareDelegate(list[j], minElement) < 0)
                    {
                        minElement = list[j];
                        minLocation = j;
                    }
                }

                if (minLocation != i)
                {
                    TValue temp = list[minLocation];
                    list[minLocation] = list[i];
                    list[i] = temp;
                }
            }
            return list;


        }

        public static IEnumerable<TValue> SelectionSort<TValue>(this IEnumerable<TValue> item) where TValue : IComparable<TValue>
        {
            var list = item.ToList();
            for (int i = 0; i < list.Count() - 1; ++i)
            {
                TValue minElement = list[i];
                int minLocation = i;

                for (int j = i + 1; j < list.Count(); ++j)
                {
                    if (list[j].CompareTo(minElement) < 0)
                    {
                        minElement = list[j];
                        minLocation = j;
                    }
                }

                if (minLocation != i)
                {
                    TValue temp = list[minLocation];
                    list[minLocation] = list[i];
                    list[i] = temp;
                }
            }
            return list;
        }
    }
}
