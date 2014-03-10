using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class FixedCapacityStackOfStrings
    {
        private String[] s;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        { s = new String[capacity]; }

        public bool isEmpty()
        { return N == 0; }

        public void push(String item)
        { s[N++] = item; }

        public String pop()
        { return s[--N]; }
    }
}
