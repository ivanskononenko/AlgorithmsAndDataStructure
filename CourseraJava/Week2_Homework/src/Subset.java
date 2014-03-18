/**
 * Created by ivko on 3/14/14.
 */
public class Subset {
    public static void main(String[] args)
    {
        RandomizedQueue<String> randomizedQueue = new RandomizedQueue<String>();
        for (String item: StdIn.readAllStrings())
            randomizedQueue.enqueue(item);

        int k = Integer.parseInt(args[0]);
        for (int i = 0; i < k; i++)
            StdOut.println(randomizedQueue.dequeue());
    }
}