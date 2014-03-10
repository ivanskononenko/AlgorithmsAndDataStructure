using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class QuickUnionUF
    {
        int[] id;

        public QuickUnionUF(int N) {
            id = new int[N];

            for(int i=0; i<id.Length;i++)
                id[i] = i;
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
            id[rootP] = rootQ;
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
            QuickUnionUF qu = new QuickUnionUF(10);

            qu.union(3, 4);
            qu.union(4, 9);
            qu.union(2, 9);

            qu.union(5, 6);

            qu.Print();

        }
    }
}
