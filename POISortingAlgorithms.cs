using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace POI
{
    /// <summary>
    /// Static class with Algorithms for Sorting maded by Poigrammer.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the array.</typeparam>
    public static class POISort<T>
    {
        //PUBLIC
        /// <summary>
        /// Selection way to sort array.<br/><br/>
        /// worst case - O(n^2)<br/>
        /// average case - O(n^2)<br/>
        /// best case - O(n^2)
        /// </summary>
        /// <param name="array">The array to sort.</param>
        /// <param name="ascendingOrder">true - ascending and false for descending.</param>
        /// <returns>The sorted array.</returns>
        public static T[] Selection(T[] array, bool ascendingOrder = true)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i; k < array.Length; k++)
                {
                    if (Order(Compare(array[i], array[k]), ascendingOrder) < 0)
                    {
                        (array[i], array[k]) = (array[k], array[i]);
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// Insertion way to sort array.<br/><br/>
        /// worst case - O(n^2)<br/>
        /// average case - O(n^2)<br/>
        /// best case - O(n)
        /// </summary>
        /// <param name="array">The array to sort.</param>
        /// <param name="ascendingOrder">true - ascending and false for descending.</param>
        /// <returns>The sorted array.</returns>
        public static T[] Insertion(T[] array, bool ascendingOrder = true)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int k = i-1, j = 0; k >= 0; k--)
                {
                    if (Order(Compare(array[k], array[i - j]), ascendingOrder) < 0)
                    {
                        (array[i-j], array[k]) = (array[k], array[i-j]);
                        j++;
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// Shell/Bubble way to sort array.<br/><br/>
        /// worst case - O(n^2)<br/>
        /// average case - O(n^2)<br/>
        /// best case - O(n)
        /// </summary>
        /// <param name="array">The array to sort.</param>
        /// <param name="ascendingOrder">true - ascending and false for descending.</param>
        /// <returns>The sorted array.</returns>
        public static T[] Shell(T[] array, bool ascendingOrder = true)
        {
            for (int i = array.Length/2, k = array.Length/2; i > 0; i--)
            {
                for (int j = 0; j < k; j++)
                {
                    if (Order(Compare(array[j], array[j+i]), ascendingOrder) < 0)
                    {
                        (array[j], array[j + i]) = (array[j + i], array[j]);
                    }
                }
                k++;
            }
            return array;
        }   
        //PRIVATE
        private static int Compare(T element1, T element2)
        {
            return Comparer<T>.Default.Compare(element1, element2);
        }
        private static int Order(int result, bool ascOrder)
        {
            if (ascOrder) return -result;
            return result;
        }
    }
}
