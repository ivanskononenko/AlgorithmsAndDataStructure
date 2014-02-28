using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

}

namespace LinkedList.Common
{
    public class LinkedListNode
    {
        public int Id { get; set; }

        public LinkedListNode Next { get; set; }
    }

    public class LinkedList : System.Collections.ICollection
    {
        public LinkedListNode Head { get; set; }
        public LinkedListNode Tail { get; set; }
        public int Count { get; private set; }

        public void AddToFront(LinkedListNode node)
        {
            // Save off the head node so we don't lose it
            LinkedListNode temp = Head;

            // Point head to the new node
            Head = node;

            // Insert the rest of the list behind the head
            Head.Next = temp;

            Count++;

            if (Count == 1)
            {
                // if the list was empty then Head and Tail should
                // both point to the new node.
                Tail = Head;
            }

        }

        public void AddToEnd(LinkedListNode node)
        {
        }

        public void RemoveFromHead()
        {

        }

        public void RemoveFromEnd()
        {

        }




        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        public object SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        public System.Collections.IEnumerator GetEnumerator()
        {
            LinkedListNode current = Head;

            while (current != null)
            {
                yield return current.Id;
                current = current.Next;
            }
        }
    }

}
