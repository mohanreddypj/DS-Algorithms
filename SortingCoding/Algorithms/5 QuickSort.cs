using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class QuickSort
    {
        public static void Sort(int[] arrayToSort)
        {
            Sort(arrayToSort, 0, arrayToSort.Length -1);
        }

        private static void Sort(int[] arrayToSort, int startIndex, int endIndex)
        {
            int leftSideCurrentIndex = startIndex;
            int rightSideCurrentIndex = endIndex;

            // this is PIVOT
            int picketPivotIndex = (startIndex + endIndex) / 2;
            int pickedPivot = arrayToSort[picketPivotIndex];

            while (true)
            {
                while (arrayToSort[leftSideCurrentIndex] < pickedPivot)
                    leftSideCurrentIndex++; // This loop stops once it finds BIGGER value than pickedItem

                while (arrayToSort[rightSideCurrentIndex] > pickedPivot)
                    rightSideCurrentIndex--; // This loop stops once it finds LESSER value than pickedItem

                if (leftSideCurrentIndex <= rightSideCurrentIndex)
                {
                    Swap(ref arrayToSort[leftSideCurrentIndex], ref arrayToSort[rightSideCurrentIndex]);

                    leftSideCurrentIndex++;
                    rightSideCurrentIndex--;
                }

                if (leftSideCurrentIndex > rightSideCurrentIndex)
                    break;
            }

            if (startIndex < rightSideCurrentIndex)
                Sort(arrayToSort, startIndex, rightSideCurrentIndex);

            if (leftSideCurrentIndex < endIndex)
                Sort(arrayToSort, leftSideCurrentIndex, endIndex);
        }

        private static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
