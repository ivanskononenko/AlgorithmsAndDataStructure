/**
 * Created by ivko on 3/11/14.
 */
public class LinkedListNode<T> {

    public LinkedListNode(T value){
        item = value;
    }

    public  T item;
    public  LinkedListNode<T> next;
    public  LinkedListNode<T> previous;
}
