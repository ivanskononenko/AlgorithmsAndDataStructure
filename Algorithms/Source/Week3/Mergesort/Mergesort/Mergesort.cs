using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mergesort
{
    public interface ISort<T>
    {
        void Sort(IEnumerable<T> elements);
        void Sort(ref T[] elements, IComparer<T> comparer);

    }

    public interface ISort
    {
        void Sort(IComparable[] elements);
    }


    public class Mergesort<T> : ISort<T>
    {
        private IComparer<T> _comparer;
        public void Sort<T>(IEnumerable<T> elements)
        {
            throw new NotImplementedException();
        }

        public void Sort(ref T[] elements, IComparer<T> comparer)
        {
            _comparer = comparer;
            T[] aux = new T[elements.Count()];
            Sort(elements, aux, 0, elements.Count() - 1);
            elements = aux;
        }

        private void Sort(T[] a, T[] aux, int lo, int hi)
        {
            if (hi <= lo)
                return;
            int mid = lo + (hi - lo) / 2;
            Sort(a, aux, lo, mid);
            Sort(a, aux, mid + 1, hi);

            Merge(a, aux, lo, mid, hi);
        }

        private void Merge(T[] a, T[] aux, int lo, int mid, int hi)
        {
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    aux[k] = a[j++];
                else if (j > hi)
                    aux[k] = a[i++];
                else if (_comparer.Compare(a[i], a[j]) < 0)
                    aux[k] = a[i++];
                else
                    aux[k] = a[j++];
            }

        }


        public void Sort(IEnumerable<T> elements)
        {
            throw new NotImplementedException();
        }

    }

    public class Mergesort : ISort
    {

        public void Sort(int[] a)
        {
            int[] aux = new int[a.Length];
            Sort(a, aux, 0, a.Length - 1);
            Console.Read();
        }

        private void Sort(int[] a, int[] aux, int lo, int hi)
        {
            if (hi <= lo)
                return;
            int mid = lo + (hi - lo) / 2;
            Sort(a, aux, lo, mid);
            Sort(a, aux, mid + 1, hi);
            Merge(a, aux, lo, mid, hi);
        }
        private void Merge(int[] a, int[] aux, int lo, int mid, int hi)
        {
            for (int k = lo; k <= hi; k++)
                aux[k] = a[k];
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++)
            {
                if (i > mid)
                    a[k] = aux[j++];
                else if (j > hi)
                    a[k] = aux[i++];
                else if (aux[i] < aux[j])
                    a[k] = aux[i++];
                else
                    a[k] = aux[j++];
            }

            Console.Write(lo + " " + hi + " " + "|");
            foreach (int el in a)
                Console.Write(" " + el);

            Console.WriteLine();
        }

        public void Sort(IComparable[] elements)
        {
            throw new NotImplementedException();
        }
    }
}
