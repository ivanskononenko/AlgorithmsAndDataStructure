using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedQuickUnionUF
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickUnionUF quickUnionUF = new QuickUnionUF(10);

            quickUnionUF.Union(4, 1);
            quickUnionUF.Union(5, 2);
            quickUnionUF.Union(2, 0);
            quickUnionUF.Union(8, 4);
            quickUnionUF.Union(2, 6);
            quickUnionUF.Union(3, 7);
            quickUnionUF.Union(5, 9);
            quickUnionUF.Union(7, 4);
            quickUnionUF.Union(5, 4);

            quickUnionUF.Print();
        }
    }

    public class QuickUnionUF
    {
        private int[] id;
        private int[] sz;

        public QuickUnionUF(int N)
        {
            id = new int[N];
            sz = new int[N];

            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }

        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        private int Root(int i)
        {
            while (i != id[i])
            {
                //id[i] = id[id[i]]; for path compression
                i = id[i];
            }
            return i;
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j)
                return;
            if (sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else
            {
                id[j] = i;
                sz[i] += sz[j];
            }
        }

        public void Print()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write("{0} ", id[i]);
            }
            Console.WriteLine();
        }
    }
}
