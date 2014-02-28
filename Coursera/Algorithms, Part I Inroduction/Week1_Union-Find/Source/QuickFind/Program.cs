using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFind
{
    class Program
    {
        static void Main(string[] args)
        {
            QuckFindUF quckFindUF = new QuckFindUF(10);
            //quckFindUF.Union(6, 9);
            //quckFindUF.Print();

            //quckFindUF.Union(6, 0);
            //quckFindUF.Print();

            //quckFindUF.Union(2, 7);
            //quckFindUF.Print();

            //quckFindUF.Union(6, 5);
            //quckFindUF.Print();

            //quckFindUF.Union(4, 2);
            //quckFindUF.Print();

            //quckFindUF.Union(4, 1);
            //quckFindUF.Print();

        }
    }

    public class QuckFindUF
    {
        private int[] id;

        public QuckFindUF(int N)
        {
            id = new int[N];

            for (int i = 0; i < N; i++)
                id[i] = i;
        }

        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            if (pid == qid)
                return;

            for (int i = 0; i < id.Length; i++)
                if (id[i] == pid)
                    id[i] = qid;
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
