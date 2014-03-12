import sun.reflect.generics.reflectiveObjects.NotImplementedException;
import java.util.Iterator;

/**
 * Created by ivko on 3/11/14.
 */
public class DoublyLinkedList<T> implements Iterable<T> {

    public LinkedListNode<T> head;
    public LinkedListNode<T> tail;
    public int count;

    // insert the item at the front
    public void addFirst(T item)   {
        LinkedListNode<T> node = new LinkedListNode<T>(item);


        LinkedListNode<T> tmp = this.head;
        this.head.previous = tmp;

        node.next = tmp;
        this.head = node;


        this.count++;

        if (this.count == 1)
            this.tail = this.head;
    }
    // insert the item at the end
    public void addLast(T item){
        LinkedListNode<T> node = new LinkedListNode<T>(item);

        if (count == 0)
            this.head = node;
        else{
            this.tail.next = node;
            node.previous = this.tail;
        }

        this.tail = node;
        this.count++;

    }

    // delete and return the item at the front
    public T removeFirst(){
        if (this.count == 0)
            return  null;

        if (count==1){
            this.head = null;
            this.tail = null;
            this.count--;
            return  null;
        }

        LinkedListNode<T> itemToRemove = this.head;
        this.head = this.head.next;
        this.count--;
        return itemToRemove.item;
    }

    public T removeLast(){
        if (this.count == 0)
            return  null;

        if (count==1){
            this.head = null;
            this.tail = null;
            this.count--;
            return  null;
        }

        LinkedListNode<T> current = this.head;
        while (current.next!=this.tail){
            current = current.next;
        }

        current.next = null;
        LinkedListNode<T> itemToRemove = this.tail;
        this.tail = current;

        return itemToRemove.item;
    }

    @Override
    public Iterator<T> iterator() {
        return new LinkedListIterator();
    }

    private  class LinkedListIterator implements  Iterator<T>{

        private  LinkedListNode<T> current = head;
        @Override
        public boolean hasNext() {
            return  current != null;
        }

        @Override
        public T next() {
            T item = current.item;
            current = current.next;
            return  item;
        }

        @Override
        public void remove() {

        }
    }

    public static  void  main(String[] args){

        LinkedList<Integer> linkedList = new LinkedList<Integer>();

        //linkedList.addLast(2);
        //linkedList.addLast(3);
        //linkedList.addLast(4);
        linkedList.addLast(6);
        linkedList.addLast(5);
        linkedList.addLast(1);


        linkedList.removeFirst();
        linkedList.removeFirst();
        linkedList.removeFirst();
        linkedList.removeFirst();


        for(int item : linkedList)
            System.out.print(" "+ item);

    }
}