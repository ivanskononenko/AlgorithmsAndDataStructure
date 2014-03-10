import org.omg.DynamicAny._DynArrayStub;

/**
 * Created by ivko on 3/6/14.
 */
public class BinarySearch {
    public static int binarySearch(int[] arr, int key)
    {
        int loIndex = 0;
        int hiIndex = arr.length-1;

        int result = 0;
        while (loIndex <=hiIndex){
            int middleIndex = (hiIndex-loIndex)/2;
            if (arr[middleIndex]< key)
                loIndex = middleIndex + 1;
            else if (arr[middleIndex] > key)
                hiIndex = middleIndex+1;
            else
                return  middleIndex;
        }

        return  -1;
    }

    public static void main(String[] args)
    {
        StdOut.println("Hello World");

        int[] a = new int[5];
        for(int i=0; i <5; i++)
            a[i] = i+2;

       int i =  binarySearch(a,6);

        if(i==-1)
            StdOut.println("Key not found");
        else
            StdOut.println("Key = "+ i);

    }
}
