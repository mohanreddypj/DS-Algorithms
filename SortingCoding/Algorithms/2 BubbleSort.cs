using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class BubbleSort
    {
        public static void Sort(int[] arrayToSort)
        {
            for (int passNumber = 0; passNumber < arrayToSort.Length; passNumber++)
            {
                for (int itemIndex = 0; itemIndex < arrayToSort.Length - 1; itemIndex++)
                {
                    if (arrayToSort[itemIndex] > arrayToSort[itemIndex + 1])
                    {
                        Swap(ref arrayToSort[itemIndex], ref arrayToSort[itemIndex + 1]);
                    }
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
