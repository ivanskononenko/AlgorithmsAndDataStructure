using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    public class ResizingArrayStackOfStrings
    {
        string[] s;
        int N = 1;
        public ResizingArrayStackOfStrings()
        {
            s = new String[N];
        }

        public void push(String item)
        {
            if (N == s.Length) 
                resize(2 * s.Length);
            s[N++] = item;
        }

        public String pop()
        {
            String item = s[--N];
            s[N] = null;
            if (N > 0 && N == s.Length / 4) resize(s.Length / 2);
            return item;
        }


        private void resize(int capacity)
        {
            String[] copy = new String[capacity];
            for (int i = 0; i < N; i++)
                copy[i] = s[i];
            s = copy;
        }

    }
}

