using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class SelectionSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int currentMinValueItemIndex = 0;

            for (int firstItemToCompareIndex = 0; firstItemToCompareIndex < arrayToSort.Length - 1; firstItemToCompareIndex++)
            {
                currentMinValueItemIndex = firstItemToCompareIndex;

                for (int secondItemToCompareIndex = firstItemToCompareIndex + 1; secondItemToCompareIndex < arrayToSort.Length; secondItemToCompareIndex++)
                {
                    if (arrayToSort[secondItemToCompareIndex] < arrayToSort[currentMinValueItemIndex])
                        currentMinValueItemIndex = secondItemToCompareIndex;
                }

                Swap(ref arrayToSort[firstItemToCompareIndex], ref arrayToSort[currentMinValueItemIndex]);
            }

        }

        private static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
