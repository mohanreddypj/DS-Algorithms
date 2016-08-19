using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class HeapSort_Max
    {
        public static void Sort(int[] arrayToHeapify)
        {
            for (int heapifyStartFromIndex = (arrayToHeapify.Length / 2) - 1; heapifyStartFromIndex >= 0; heapifyStartFromIndex--)
                Heapify(arrayToHeapify, heapifyStartFromIndex, arrayToHeapify.Length);

            for (int index = arrayToHeapify.Length - 1; index >= 1; index--)
            {
                Swap(ref arrayToHeapify[0], ref arrayToHeapify[index]);
                Heapify(arrayToHeapify, 0, index - 1);
            }
        }


        private  static void Heapify(int[] arrayToHeapify, int treeRootItemIndex, int arrayLastItemIndex)
        {
            bool isHeapifyCompleted = false;
            int treeMaxItemIndex;

            while ((treeRootItemIndex * 2 <= arrayLastItemIndex) && (!isHeapifyCompleted))
            {
                int leftChildItemIndex = treeRootItemIndex * 2;
                int rightChildItemIndex = treeRootItemIndex * 2 + 1;

                if (leftChildItemIndex == arrayLastItemIndex)
                    treeMaxItemIndex = leftChildItemIndex;

                else if (arrayToHeapify[leftChildItemIndex] > arrayToHeapify[rightChildItemIndex])
                    treeMaxItemIndex = leftChildItemIndex;

                else
                    treeMaxItemIndex = rightChildItemIndex;

                if (arrayToHeapify[treeRootItemIndex] < arrayToHeapify[treeMaxItemIndex])
                {
                    Swap(ref arrayToHeapify[treeRootItemIndex], ref arrayToHeapify[treeMaxItemIndex]);
                    treeRootItemIndex = treeMaxItemIndex;
                }
                else
                {
                    isHeapifyCompleted = true;
                }
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
