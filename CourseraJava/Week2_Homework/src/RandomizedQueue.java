
import java.util.Iterator;


/**
 * Created by ivko on 3/13/14.
 */
public class RandomizedQueue<Item> implements Iterable<Item> {
    private Item[] items = (Item[])new Object[0];
    private int size;
    // The current number of items in the stack.


    // construct an empty randomized queue
    public RandomizedQueue()              {

    }
    // is the queue empty?
    public boolean isEmpty(){
        return  this.size == 0;
    }

    // return the number of items on the queue
    public int size(){
        return  this.size;
    }

    //Throw a NullPointerException if the client attempts to add a null item
    public void enqueue(Item item){
        if (item == null)
            throw new  NullPointerException();

        if(this.size == items.length){
            if (this.size == 0)
                resize(1);
            else
                resize(2*this.size);

        }

       this.items[this.size++] = item;
    }

    // delete and return a random item
    //throw a java.util.NoSuchElementException if the client attempts to sample or dequeue an item from an empty randomized queue
    public Item dequeue()  {
        if(this.size == 0)
            throw  new java.util.NoSuchElementException();

        int randomIndex = StdRandom.uniform(0,this.size);
        Item randomItem = this.items[randomIndex];

        this.items[randomIndex] = this.items[this.size - 1];
        this.items[--this.size] = null;

        if (this.size>0 && this.size == this.items.length/4)
            resize(this.items.length / 2);

        return  randomItem;
    }

    // return (but do not delete) a random item
    public Item sample(){
        if(this.size == 0)
          throw  new java.util.NoSuchElementException();

        int randomUniformNumber = StdRandom.uniform(0, this.size);
        return  this.items[randomUniformNumber];
    }

    public Iterator<Item> iterator(){
       return new RandomizedIterator();
    }

    private void resize(int newSize){
        Item[] copy = (Item[])new Object[newSize];
        for(int i=0; i<size; i++)
            copy[i] = this.items[i];
        this.items = copy;
    }

    private class  RandomizedIterator implements Iterator<Item> {

        private int currentIndex = 0;
        private Item[] shuffledItems;

        public  RandomizedIterator(){
            shuffledItems = (Item[]) new Object[size];
            for(int i=0;i< size; i++){
                shuffledItems[i] = items[i];
            }
            StdRandom.shuffle(shuffledItems);
        }
        @Override
        public boolean hasNext() {
            return this.currentIndex<size;
        }

        @Override
        //Throw a java.util.NoSuchElementException if the client calls the next() method in the iterator and there are no more items to return
        public Item next() {
            if (!hasNext())
                throw new java.util.NoSuchElementException();
            return this.shuffledItems[currentIndex++];
        }

        @Override
        //Throw an UnsupportedOperationException if the client calls the remove() method in the iterator
        public void remove() {
            throw new UnsupportedOperationException();
        }
    }

    // return an independent iterator over items in random order
    public static void main(String[] args)   {

        RandomizedQueue<Integer> queue = new RandomizedQueue<Integer>();

        queue.enqueue(3);
        queue.enqueue(19);
        queue.enqueue(10);
        queue.enqueue(7);
        queue.enqueue(15);
        queue.enqueue(2);


//        StdOut.print(" " + queue.sample());
//        StdOut.print(" " + queue.sample());
//        StdOut.print(" " + queue.sample());
//        StdOut.print(" " + queue.sample());
//        StdOut.print(" " + queue.sample());

        for(int el : queue)
            StdOut.print(" " + el);
    }
}