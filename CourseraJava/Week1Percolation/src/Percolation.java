import sun.reflect.generics.reflectiveObjects.NotImplementedException;

/**
 * Created by ivko on 3/4/14.
 */
public class Percolation {
    private int[][] percolationGrid;

    public Percolation(int N)
    {
        percolationGrid = new int[N][N];

        for(int i=0; i<N;i++)
            for(int j=0;j<N;j++)
                percolationGrid[i][j] = 0;


    }

    public void open(int i, int j){
        throw  new NotImplementedException();
    }

    public boolean isOpen(int i, int j) {
        return percolationGrid[i][j] == 1;
    }

    public boolean isFull(int i, int j){
        throw  new NotImplementedException();
    }

    public boolean percolates(){
        throw  new NotImplementedException();
    }


    public static void main(String[] args)
    {
          Percolation p = new Percolation(4);
    }
}
