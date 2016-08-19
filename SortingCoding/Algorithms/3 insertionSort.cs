using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class InsertionSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int sortedUptoItemIndex = 0;
            int extractedItem = 0;

            for (int currentItemIndex = 1; currentItemIndex < arrayToSort.Length; currentItemIndex++)
            {
                sortedUptoItemIndex = currentItemIndex;
                extractedItem = arrayToSort[currentItemIndex];

                while ((sortedUptoItemIndex > 0) && (arrayToSort[sortedUptoItemIndex - 1] > extractedItem))
                {
                    arrayToSort[sortedUptoItemIndex] = arrayToSort[sortedUptoItemIndex - 1];
                    sortedUptoItemIndex = sortedUptoItemIndex - 1;
                }

                arrayToSort[sortedUptoItemIndex] = extractedItem;
            }
        }
    }
}
