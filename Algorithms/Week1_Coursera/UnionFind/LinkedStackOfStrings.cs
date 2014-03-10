using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class LinkedStackOfStrings
    {
        private Node first = null;

        private class Node
        {
            public string item;
            public Node next;
        }

        public bool isEmpty()
        { 
            return first == null; 
        }

        public void push(string item)
        {
            Node oldfirst = first;
            first = new Node();
            first.item = item;
            first.next = oldfirst;
        }

        public String pop()
        {
            String item = first.item;
            first = first.next;
            return item;
        }
    }
}
