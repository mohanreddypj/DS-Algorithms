using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Datastructures.Linear
{
    public class Stack
    {
        int[] stackArray;
        int topIndex = -1;
        int stackSize = 0;

        public Stack(int length) // with array implemention.
        {
            stackArray = new int[length];
        }

        public void push(int value)
        {
            if (topIndex == stackSize)
                throw new Exception("Stack is full.");

            stackArray[topIndex] = value;
            topIndex++;
        }

        public int Pop()
        {
            if (topIndex < 0)
                throw new Exception("Stack is empty.");

            int valueToReturn = stackArray[topIndex - 1];
            topIndex--;

            return valueToReturn;
        }
    }
}
