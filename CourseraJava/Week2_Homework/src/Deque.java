/**
 * Created by ivko on 3/13/14.
 */

import java.util.Iterator;

public class Deque<Item> implements Iterable<Item> {

        private DoublyLinkedList doublyLinkedList = null;

        public Deque(){
            this.doublyLinkedList = new DoublyLinkedList();
        }

        public boolean isEmpty() {
            return  this.doublyLinkedList.count == 0;
        }

        public int size(){
            return  this.doublyLinkedList.count;
        }

        // insert the item at the front
        public void addFirst(Item item){
            this.doublyLinkedList.addFirst(item);
        }

        // insert the item at the end
        public void addLast(Item item)  {
            this.doublyLinkedList.addLast(item);

        }

        // delete and return the item at the front
        public Item removeFirst(){
           return  this.doublyLinkedList.removeFirst();
        }

        // delete and return the item at the end
        public Item removeLast(){
            return  this.doublyLinkedList.removeLast();
        }

        // return an iterator over items in order from front to end
        public Iterator<Item> iterator(){
            return this.doublyLinkedList.iterator();
        }

        // unit testing
        public static void main(String[] args){
            Deque<Integer> list = new Deque<Integer>();

            list.addFirst(3);
            list.addFirst(4);
            list.addFirst(5);

            list.addLast(2);
            list.addLast(1);

            list.removeFirst();
            list.removeLast();
            list.removeLast();
            list.removeLast();
            list.removeLast();
            //list.removeLast();
            for(int el : list)
                StdOut.print(" " + el);
        }

        private class DoublyLinkedList{

            public int count = 0;

            private  DoublyLinkedListNode<Item> head;
            private  DoublyLinkedListNode<Item> tail;

            // insert the item at the front
            public void addFirst(Item item){
                if (item == null)
                    throw new NullPointerException();

                DoublyLinkedListNode<Item> node = new DoublyLinkedListNode<Item>(item);

                if (this.count == 0){
                    this.head = this.tail = node;
                    this.count++;
                    return;
                }

                DoublyLinkedListNode tmp = head;
                head = node;
                head.next = tmp;
                tmp.previous = head;

                this.count++;
            }

            public  void addLast(Item item){
                if (item == null)
                    throw new NullPointerException();

                DoublyLinkedListNode<Item> node = new DoublyLinkedListNode<Item>(item);

                if (this.count == 0){
                    this.head = this.tail = node;
                    this.count++;
                    return;
                }

                this.tail.next = node;
                node.previous = this.tail;
                this.tail = node;
                this.count++;
            }

            public  Item  removeFirst(){
                if(this.count == 0)
                   throw new java.util.NoSuchElementException();

                DoublyLinkedListNode<Item> tmp = this.head;
                if (this.count == 1){
                    this.head = this.tail = null;
                    this.count--;
                    return tmp.item;
                }

                this.head = this.head.next;
                this.head.previous = null;

                this.count--;
                return tmp.item;
            }

            public  Item removeLast(){
                if(this.count == 0)
                    throw new java.util.NoSuchElementException();

                DoublyLinkedListNode<Item> tmp = this.tail;
                if (this.count == 1){
                    this.head = this.tail = null;
                    this.count--;
                    return tmp.item;
                }

                this.tail = this.tail.previous;
                this.tail.next = null;

                this.count--;
                return  tmp.item;
            }

            public Iterator<Item> iterator(){
                return new DoublyLinkedListIterator();
            }

            private  class DoublyLinkedListIterator implements  Iterator<Item>{
                DoublyLinkedListNode<Item> current = head;

                @Override
                public boolean hasNext() {
                    return current != null;
                }

                @Override
                public Item next() {
                    if (!hasNext())
                        throw  new java.util.NoSuchElementException();
                    Item val = current.item;
                    current = current.next;
                    return val;
                }

                @Override
                public void remove() {
                    throw  new UnsupportedOperationException();
                }
            }

            private  class DoublyLinkedListNode<Item> {

                public DoublyLinkedListNode(Item value){
                    this.item = value;
                }

                public  Item item;
                public  DoublyLinkedListNode<Item> next;
                public  DoublyLinkedListNode<Item> previous;
            }
        }
 }

