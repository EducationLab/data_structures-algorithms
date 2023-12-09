using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Utility
    {
        /// <summary>
        /// Sorts the given list in ascending order using bubble sort.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int[] SortAscending(int[] list)
        {
            int temp;
            for (int j = 0; j < list.Length; j++)
            {
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// Sorts the list in descending order using bubble sort.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int[] SortDescending(int[] list)
        {
            int temp;
            for (int j = 0; j < list.Length; j++)
            {
                for (int i = 0; i < list.Length - 1; i++)
                {
                    if (list[i] < list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Searches a sorted list using binary search. Returns the index;
        /// </summary>
        /// <param name="list"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public static int SearchSorted(int[] list, int criteria)
        {
            int min = 0;
            int max = list.Length - 1;
            int mid;

            do
            {
                mid = (min + max) / 2;
                if (list[mid] == criteria)
                    return mid;
                if (criteria > list[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (min <= max);
            return -1;
        }

        /// <summary>
        /// Searches an unsorted list using sequential/linear search. Returns the index.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="criteria"></param>
        /// <returns></returns>
        public static int SearchUnsorted(int[] list, int criteria)
        {
            int i = 0;
            bool found = false;

            while (!found && i < list.Length)
            {
                if (list[i] == criteria)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            if (i < list.Length) // Was wrong operator
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
    }
}
