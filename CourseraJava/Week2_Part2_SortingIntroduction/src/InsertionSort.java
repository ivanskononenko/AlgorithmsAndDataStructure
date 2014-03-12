import sun.tools.jar.resources.jar;

/**
 * Created by ivko on 3/12/14.
 */
public class InsertionSort {

    public static  void sort(Comparable[] a){
        for(int i=0; i<a.length; i++){
            for(int j=i; j>0;j--){
                if(less(a[j], a[j-1])){
                    exch(a,j,j-1);
                }else{
                    break;
                }

                for (Comparable v : a)
                    System.out.print(" " + v);

                System.out.println();
            }
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

        InsertionSort.sort(arrForSort);

        for (int v : arrForSort)
            System.out.print(" " + v);
    }
}
