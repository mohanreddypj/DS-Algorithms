using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class MergeSort
    {
        public static void Sort(int[] arrayToSort)
        {
            Sort(arrayToSort, 0, arrayToSort.Length - 1);
        }

        private static void Sort(int[] arrayToSort, int startIndex, int endIndex)
        {
            int midIndex = 0;

            if (startIndex < endIndex)
            {
                midIndex = (startIndex + endIndex) / 2;

                Sort(arrayToSort, startIndex, midIndex);
                Sort(arrayToSort, midIndex + 1, endIndex);

                Merge(arrayToSort, startIndex, midIndex, endIndex);
            }
        }
        private static void Merge(int[] arrayToSort, int startIndex, int midIndex, int endIndex)
        {
            int totalItemsToMerge = (endIndex - startIndex) + 1;
            int[] tempArray = new int[totalItemsToMerge];
            int tempArrayIndexToFill = 0;

            int leftPartIndex = startIndex;
            int rightPartIndex = midIndex + 1;

            while (leftPartIndex <= midIndex && rightPartIndex <= endIndex)
            {
                if (arrayToSort[leftPartIndex] <= arrayToSort[rightPartIndex])
                {
                    tempArray[tempArrayIndexToFill] = arrayToSort[leftPartIndex];

                    leftPartIndex++;
                    tempArrayIndexToFill++;
                }
                else
                {
                    tempArray[tempArrayIndexToFill] = arrayToSort[rightPartIndex];

                    rightPartIndex++;
                    tempArrayIndexToFill++;
                }
            }

            // When all left side item are copied and stil right side we have few elements
            // now, leftPartIndex goes to more than midIndex.

            if (leftPartIndex > midIndex)
            {
                for (int localIndex = rightPartIndex; localIndex <= endIndex; localIndex++)
                {
                    tempArray[tempArrayIndexToFill] = arrayToSort[rightPartIndex];

                    rightPartIndex++;
                    tempArrayIndexToFill++;
                }
            }
            else // Left side, few items are still availble
            {
                for (int localIndex = leftPartIndex; localIndex <= midIndex; localIndex++)
                {
                    tempArray[tempArrayIndexToFill] = arrayToSort[leftPartIndex];

                    leftPartIndex++;
                    tempArrayIndexToFill++;
                }
            }


            // Copy items from temporary array to actual array.
            for (int tempArrayIndex = 0, indexToStartInInputArray = startIndex; tempArrayIndex < tempArray.Length; tempArrayIndex++, indexToStartInInputArray++)
            {
                arrayToSort[indexToStartInInputArray] = tempArray[tempArrayIndex];
            }
        }
    }
}
