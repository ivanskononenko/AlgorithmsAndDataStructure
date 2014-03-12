

/**
 * Created by ivko on 3/12/14.
 */
public class SelectionSort {

    public static  void sort(Comparable[] a){
        for(int i=0; i <a.length; i++)
        {
            int min = i;
            for(int j=i+1; j<a.length;j++)
            {
                if (less(a[j], a[min]))
                    min = j;
            }
            exch(a,i, min);
        }
    }

    private  static  boolean less(Comparable v, Comparable w){
        return v.compareTo(w)< 0;
    }

    private  static  void exch(Comparable[] a, int i, int j){
        Comparable swap = a[i];
        a[i] = a[j];
        a[j] = swap;
    }

    public  static  void  main(String[] args){
        Integer[] arrForSort = {6,5,4,8,9,0};

        SelectionSort.sort(arrForSort);

        for (int v : arrForSort)
            System.out.print(" " + v);
    }

}
