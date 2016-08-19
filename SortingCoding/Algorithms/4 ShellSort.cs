using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Algorithms
{
    public class ShellSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int shellLength = (arrayToSort.Length) / 2;

            while (shellLength > 0)
            {
                for (int itemIndex = 0; itemIndex < arrayToSort.Length - shellLength; itemIndex++)
                {
                    int compareToItemIndex = itemIndex + shellLength;
                    int extractedItem = arrayToSort[compareToItemIndex];

                    while ((compareToItemIndex >= shellLength)
                            && extractedItem < arrayToSort[compareToItemIndex - shellLength])
                    {
                        arrayToSort[compareToItemIndex] = arrayToSort[compareToItemIndex - shellLength];
                        compareToItemIndex = compareToItemIndex - shellLength;
                    }
                    arrayToSort[compareToItemIndex] = extractedItem;
                }

                if (shellLength / 2 != 0)
                    shellLength = shellLength / 2;
                else if (shellLength == 1)
                    shellLength = 0;
                else
                    shellLength = 1;
            }

        }
    }
}
