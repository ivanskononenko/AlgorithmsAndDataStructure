using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class Percolation
    {
        private bool[,] percolationGrid;
        private int gridDimension;
        private int virtualBottom;
        private int virtualTop;
        private WeightedQuickUnion weightedQuickUnionUF;
        private WeightedQuickUnion weightedQuickUnionUFForFull;

        // create N-by-N grid, with all sites blocked
        public Percolation(int N)
        {
            gridDimension = N;
            percolationGrid = new bool[gridDimension, gridDimension];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    percolationGrid[i, j] = false;

            virtualBottom = gridDimension * gridDimension;
            virtualTop = virtualBottom + 1;
            weightedQuickUnionUF = new WeightedQuickUnion(gridDimension * gridDimension + 2);
            weightedQuickUnionUFForFull = new WeightedQuickUnion(gridDimension * gridDimension + 2);
        }

        // open site (row i, column j) if it is not already
        public void open(int i, int j)
        {
            validateIndexes(i, j);
            if (isOpen(i, j))
                return;

            percolationGrid[i - 1, j - 1] = true;

            int currentValueForQU = getValueForQU(i, j);
            if (i != 1 && isOpen(i - 1, j))
            {
                weightedQuickUnionUF.union(currentValueForQU, getValueForQU(i - 1, j));
                weightedQuickUnionUFForFull.union(currentValueForQU, getValueForQU(i - 1, j));
            }

            if (j != gridDimension && isOpen(i, j + 1))
            {
                weightedQuickUnionUF.union(currentValueForQU, getValueForQU(i, j + 1));
                weightedQuickUnionUFForFull.union(currentValueForQU, getValueForQU(i, j + 1));
            }

            if (i != gridDimension && isOpen(i + 1, j))
            {
                weightedQuickUnionUF.union(currentValueForQU, getValueForQU(i + 1, j));
                weightedQuickUnionUFForFull.union(currentValueForQU, getValueForQU(i + 1, j));
            }

            if (j != 1 && isOpen(i, j - 1))
            {
                weightedQuickUnionUF.union(currentValueForQU, getValueForQU(i, j - 1));
                weightedQuickUnionUFForFull.union(currentValueForQU, getValueForQU(i, j - 1));
            }

            if (i == 1)
            {
                weightedQuickUnionUF.union(currentValueForQU, virtualTop);
                weightedQuickUnionUFForFull.union(currentValueForQU, virtualTop);
            }

            if (i == gridDimension)
                weightedQuickUnionUF.union(currentValueForQU, virtualBottom);
        }

        // is site (row i, column j) open?
        public bool isOpen(int i, int j)
        {
            validateIndexes(i, j);
            return percolationGrid[i - 1, j - 1];
        }

        // is site (row i, column j) full?
        public bool isFull(int i, int j)
        {
            validateIndexes(i, j);
            return percolationGrid[i - 1, j - 1] && weightedQuickUnionUFForFull.connected(getValueForQU(i, j), virtualTop);
        }

        // does the system percolate?
        public bool percolates()
        {
            return weightedQuickUnionUF.connected(virtualBottom, virtualTop);
        }

        private int getValueForQU(int i, int j)
        {
            return (i - 1) * gridDimension + j - 1;
        }

        private void validateIndexes(int i, int j)
        {
            if (i <= 0 || i > gridDimension) throw new IndexOutOfRangeException("row index i out of bounds");
            if (j <= 0 || j > gridDimension) throw new IndexOutOfRangeException("row index j out of bounds");

        }

        static void Main(string[] args)
        {
            Percolation perc = new Percolation(3);
            // perc.open(2,2);
            // perc.open(1,2);
            perc.open(3, 1);
            perc.open(1, 3);
            perc.open(2, 3);
            perc.open(3, 3);
            perc.isFull(3, 1);

        }

    }
}
