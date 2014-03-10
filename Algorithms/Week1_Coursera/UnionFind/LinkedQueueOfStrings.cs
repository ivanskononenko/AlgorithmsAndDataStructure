using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class LinkedQueueOfStrings
    {
        private Node first, last;

        public bool isEmpty()
        { return first == null; }
        public void enqueue(String item)
        {
            Node oldlast = last;
            last = new Node();
            last.item = item;
            last.next = null;
            if (isEmpty()) first = last;
            else oldlast.next = last;
        }
        public String dequeue()
        {
            String item = first.item;
            first = first.next;
            if (isEmpty()) last = null;
            return item;
        }

        private class Node
        {
            public string item;
            public Node next;
        }
    }
}
