using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class QuickFindUF
    {
        int[] id;

        public QuickFindUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
                id[i] = i;
        }

        public bool connected(int p, int q)
        {
            return id[p] == id[q];
        }

        public void union(int p, int q)
        {
            if (connected(p, q))
                return;

            int pid = id[p];
            int qid = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == pid)
                    id[i] = qid;
            }
        }

        public void Print() {
            foreach (int i in id) {
                Console.Write(" " + i.ToString());                
            }
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            QuickFindUF qu = new QuickFindUF(10);

            qu.union(5, 6);
            qu.union(6, 0);

            qu.union(7, 2);
            qu.union(2, 1);

            qu.union(3, 4);
            qu.union(4, 9);
            qu.union(9, 8);

            qu.Print();

        }

    }


}
