using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingCoding.Datastructures.Linear
{
    public class LinkedList_Int
    {
        private Node RootNode { get; set; }

        public void Add(int value)
        {
            if (RootNode == null)
            {
                RootNode = new Node() { Value = 1 };
            }
            else
            {
                Node lastNode;
                while (true)
                {
                    lastNode = RootNode;

                    if (RootNode.NextNode != null)
                        continue;
                    else
                    {
                        lastNode.NextNode = new Node() { Value = value };

                    }
                }
            }
        }

        public void Remove(int value)
        {

        }

        public bool Exists(int value)
        {
            return false;
            
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
    }
}
