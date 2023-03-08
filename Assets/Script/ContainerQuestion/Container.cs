using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Algorithm
{
    public class Container
    {
        private class Node
        {
            public Node Next;
            public Node Prev;
            public bool Value;

            // public int testValue;
            public Node(Node prev)
            {
                var randomGen = new Random(DateTime.Now.Millisecond);
                Value = randomGen.Next(2) < 1;
                Prev = prev;
            }
        }

        private int _size;
        private Node current;

        public Container(int count = 0)
        {
            if (count < 1)
            {
                var randomGen = new Random(DateTime.Now.Millisecond);
                _size = randomGen.Next(1, 9999); //Could be up to Int32.MaxValue, reduced for sake of test memory
            }
            Node prev = null;
            for (int i = 0; i < _size; i++)
            {
                var currentNode = new Node(prev); //give prev node when initialize
                // currentNode.testValue = i;
                if (prev != null)
                {
                    prev.Next = currentNode; //prev node connects current node to build double linked list
                }
                if (current == null)
                {
                    current = currentNode; //initial the head node, only executed once
                }
                prev = currentNode;
            }
            prev.Next = current;
            current.Prev = prev;
        }

        public bool Value
        {
            get { return current.Value; }
            set { current.Value = value; }
        }
        public void MoveForward()
        {
            current = current.Next;
        }

        public void MoveBackward()
        {
            current = current.Prev;
        }
        public int Size
        {
            get => _size;
            set => _size = value;
        }

        // unsafe public int* TestGetValue()
        // {
        //     return &current.Value;
        // }
    }
}
