import sun.reflect.generics.reflectiveObjects.NotImplementedException;

import java.util.Iterator;

/**
 * Created by ivko on 3/11/14.
 */
public class LinkedList<T> implements Iterable<T> {
    // insert the item at the front
    public void addFirst(T item)   {
        throw new NotImplementedException();
    }
    // insert the item at the end
    public void addLast(T item){
        throw new NotImplementedException();
    }

    // delete and return the item at the front
    public T removeFirst(){
        throw new NotImplementedException();
    }

    public T removeLast(){
        throw new NotImplementedException();
    }

    @Override
    public Iterator<T> iterator() {
        return null;
    }

    private  class LinkedListIterator implements  Iterator<T>{

        @Override
        public boolean hasNext() {
            return false;
        }

        @Override
        public T next() {
            return null;
        }

        @Override
        public void remove() {

        }
    }
}
