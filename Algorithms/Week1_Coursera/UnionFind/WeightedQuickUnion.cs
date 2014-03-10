using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class WeightedQuickUnion
    {

        int[] id;
        int[] sz;

        public WeightedQuickUnion(int N)
        {
            id = new int[N];
            sz = new int[N];

            for (int i = 0; i < id.Length; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        private int root(int i)
        {
            while (id[i] != i)
                i = id[i];
            return i;
        }

        public bool connected(int p, int q)
        {
            return root(p) == root(q);
        }

        public void union(int p, int q)
        {
            int rootP = root(p);
            int rootQ = root(q);
            if (rootP == rootQ)
                return;
            if (sz[rootP] < sz[rootQ])
            {
                id[rootP] = rootQ;
                sz[rootQ] += sz[rootP];
            }
            else
            {
                id[rootQ] = rootP;
                sz[rootP] += sz[rootQ];
            }

        }
        public void Print()
        {
            foreach (int i in id)
            {
                Console.Write(" " + i.ToString());
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            WeightedQuickUnion qu = new WeightedQuickUnion(10);

            qu.union(4, 3);
            qu.union(3, 8);
            qu.union(6, 5);
            qu.union(9, 4);
            qu.union(2, 1);
            qu.union(5, 0);
            qu.union(7, 2);
            qu.union(6, 1);
            qu.union(7, 3);



            qu.Print();

        }
    }
}
