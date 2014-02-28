using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickUnionUF
{
    class Program
    {
        static void Main(string[] args)
        {
            QuckUnionUF quickUnionUF = new QuckUnionUF(10);

            quickUnionUF.Union(6, 9);
            quickUnionUF.Print();

            quickUnionUF.Union(6, 0);
            quickUnionUF.Print();

            quickUnionUF.Union(2, 7);
            quickUnionUF.Print();

            quickUnionUF.Union(6, 5);
            quickUnionUF.Print();

            quickUnionUF.Union(4, 2);
            quickUnionUF.Print();

            quickUnionUF.Union(4, 1);
            quickUnionUF.Print();

        }
    }

    public class QuckUnionUF
    {
        private int[] id;

        public QuckUnionUF(int N)
        {
            id = new int[N];

            for (int i = 0; i < N; i++)
                id[i] = i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        private int Root(int i)
        {
            while (i != id[i])
                i = id[i];
            return i;
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            id[i] = j;
        }

        public void Print()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write("{0} ", id[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
